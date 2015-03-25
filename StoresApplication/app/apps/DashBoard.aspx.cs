using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DashBoard : System.Web.UI.Page
{
    DatabaseHandler dh = new DatabaseHandler();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                MultiView2.ActiveViewIndex = 0;
                GetProfitByProductType();
                loadUniqdate();
            }
            GetProfitByProductType();
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
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

    private void GetProfitByProductType()
    {
         DateTime date;
         if (DropDownList1.SelectedValue == "0" || DropDownList1.SelectedValue == "")
        { 
        date =DateTime.Parse("June/1/2014 ");
        }
        else
        {
            date = DateTime.Parse(DropDownList1.SelectedValue); 
        }
        DataGrid1.DataSource = dh.GetProfitByProductType(date);
        DataGrid1.DataBind();
        DataGrid2.DataSource = dh.GetSummarySalesByMonth();
        DataGrid2.DataBind();
    }
    protected void BtnSearch_Click(object sender, EventArgs e)
    {

    }
    protected void BtnCompleteSubmit_Click(object sender, EventArgs e)
    {

    }
    protected void cboSearchType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cboSearchType.SelectedIndex == 0)
        {
            //Response.Redirect("PerformanceByProductType.aspx");
        }
        else if (cboSearchType.SelectedIndex == 1)
        {
            Response.Redirect("PerformanceByProductType.aspx");
        }
        else if (cboSearchType.SelectedIndex == 2)
        {
            Response.Redirect("MonthlyPerformance.aspx");
        }
        else if (cboSearchType.SelectedIndex == 3)
        {
            Response.Redirect("MonthlyPerformance.aspx");
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    private void loadUniqdate()
    {
        try {
            DropDownList1.DataSource = dh.GetUniqueReportDate();
            DropDownList1.DataValueField = "ReportDate";
            DropDownList1.DataTextField = "ReportDate1";
            DropDownList1.DataBind();
        }
        catch(Exception ex)
        {
            Message(ex.Message, true);
        }
    }

    protected void DropDownList1_DataBound(object sender, EventArgs e)
    {
        DropDownList1.Items.Insert(0, new ListItem("-- Select --", "0"));
    }
}