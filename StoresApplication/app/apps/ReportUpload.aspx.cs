using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data;
using System.Collections;
using System.Data.OleDb;

public partial class ReportUpload : System.Web.UI.Page
{
    DatabaseHandler dh = new DatabaseHandler();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if(!IsPostBack)
            {
                GetBraches();
            }
        }
        catch (Exception ex)
        {
            Message(ex.Message.ToString(), true);
        }
    }
    private void Message(string GetMessage, bool ColorRed)
    {
        Label msg = (Label)Master.FindControl("lblmsg");
        msg.Visible = true;
        if (ColorRed == true) { msg.ForeColor = System.Drawing.Color.Red; msg.Font.Bold = true; }
        else { msg.ForeColor = System.Drawing.Color.Blue; msg.Font.Bold = true; }
        msg.Text = "MESSAGE:  ............" + GetMessage + "............";
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (FileUpload1.FileName.Trim().Equals(""))
            {
                Label msg = (Label)Master.FindControl("lblmsg");
                msg.Text = "MESSAGE:  " + "Please select a Report to Upload.";
            }
            else 
            {
                readExcelfile();
            }
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
        }
    }
    private string ReturnPathOfUploadedFile()
    {
        string filepath = "";
        if (FileUpload1.HasFile)
        {
            try
            {
                string filename = Path.GetFileName(FileUpload1.FileName);
                string path = "G:\\Reports\\";
                filepath = path + filename;
                FileUpload1.SaveAs(filepath);
            }
            catch (Exception ex)
            {
                Message("File failed to upload report with the following error"+ex.Message, true);
            }
        }

        return filepath;
    }
  

    private void readExcelfile()
    {
        string FilePath = ReturnPathOfUploadedFile();
        string filename = string.Empty;
        //To check whether file is selected or not to uplaod
        if (FileUpload1.HasFile)
        {
            try
            {
                string[] allowdFile = { ".xls", ".xlsx" };
                //Here we are allowing only excel file so verifying selected file pdf or not
                string FileExt = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
                //Check whether selected file is valid extension or not
                bool isValidFile = allowdFile.Contains(FileExt);
                if (!isValidFile)
                {
                    Message("File format expected is Excel", true);
                }
                else
                {
                        filename = Path.GetFileName(FileUpload1.FileName);
                        string filePath = FilePath;
                        //Open the connection with excel file based on excel version
                        OleDbConnection con = null;
                        if (FileExt == ".xls")
                        {
                            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0;");

                        }
                        else if (FileExt == ".xlsx")
                        {
                            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0;");
                        }
                        con.Open();
                        //Get the list of sheet available in excel sheet
                        DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        //Get first sheet name
                        string getExcelSheetName = dt.Rows[0]["Table_Name"].ToString();
                        //Select rows from first sheet in excel sheet and fill into dataset
                        OleDbCommand ExcelCommand = new OleDbCommand(@"SELECT * FROM [" + getExcelSheetName + @"]", con);
                        OleDbDataAdapter ExcelAdapter = new OleDbDataAdapter(ExcelCommand);
                        DataSet ExcelDataSet = new DataSet();
                        ExcelAdapter.Fill(ExcelDataSet);
                        con.Close();
                        
                        DataTable RDT = ExcelDataSet.Tables[0];
                        string ReportMonth = RDT.Rows[3][0].ToString();
                        string str2 = ReportMonth;
                        int index = ReportMonth.IndexOf("-");
                        if (index > 0)
                        { ReportMonth = ReportMonth.Substring(0, index); }
                        string Date = ReportMonth + "/" + "1" +"/"+ "20" + str2.Substring(str2.LastIndexOf('-') + 1);
                        String branchCode = RDT.Rows[0][2].ToString();
                        if (ddlbranch.SelectedValue.ToUpper() != branchCode.ToUpper())
                        {
                            Message("The Selected Branch doesn't match the BranchCode in the Report", true);
                        }
                        else if (ReportMonth.ToUpper() != ddlMonth.SelectedValue.ToUpper())
                        {
                            Message("The Selected Month doesn't match the Month in the Report", true);
                        }
                        else
                        {
                            int reportExists=0;
                            reportExists = dh.CheckIfReportExists(branchCode, ReportMonth).Rows.Count;
                            if (reportExists > 0)
                            {
                                Message("The Report you are trying to upload exists..", true);
                            }
                            else
                            {
                                
                                int UnitsSold = 0;
                                int sellingPrice = 0;
                                int CostPrice = 0;
                                int Total = 0;
                                int totalsales = 0;
                                int totalcost = 0;
                                foreach (DataRow dr in RDT.Rows)
                                {
                                    string firstrow = dr[0].ToString();
                                    int count = dh.CheckIfItemCodeisValid(firstrow).Rows.Count;
                                    if (count > 0)
                                    {
                                        UnitsSold = int.Parse(dr[2].ToString());
                                        sellingPrice = int.Parse(dr[4].ToString());
                                        CostPrice = int.Parse(dr[3].ToString());
                                        totalcost = UnitsSold * CostPrice;
                                        totalsales = UnitsSold * sellingPrice;
                                        //saving files.............
                                        dh.SaveReportItems(firstrow, UnitsSold, CostPrice, sellingPrice, totalsales, totalcost, DateTime.Parse(Date), DateTime.Now, branchCode);
                                        Message("Report has been Uploaded", false);
                                    }
                                }
                                dh.SaveUploadedReports(filename, RDT.Rows[0][2].ToString(), DateTime.Now, ddlMonth.SelectedValue);
                            }
                        }
                }
            }
            catch (Exception ex)
            {
                Message("Error occurred while uploading a file: " + ex.Message, true); 
            }
        }
        else
        {
            Message("Please select a file to upload.", true);
        }
    }
    private void GetBraches()
    {
        ddlbranch.DataSource = dh.GetBraches();
        ddlbranch.DataValueField = "BranchCode";
        ddlbranch.DataTextField = "BranchName";
        ddlbranch.DataBind();
    }
    protected void ddlbranch_DataBound(object sender, EventArgs e)
    {
        ddlbranch.Items.Insert(0, new ListItem("-- Select --", "0"));
    }
    protected void ddlMonth_DataBound(object sender, EventArgs e)
    {

        ddlMonth.Items.Insert(0, new ListItem("-- Select --", "0"));
    }

}