using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GeneralSalesReport : System.Web.UI.Page
{
    DatabaseHandler dh = new DatabaseHandler();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
               
                loadUniqdate();
            }
          
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
        }
    }

    private void loadUniqdate()
    {
        try
        {
            DropDownList1.DataSource = dh.GetUniqueReportDate();
            DropDownList1.DataValueField = "ReportDate";
            DropDownList1.DataTextField = "ReportDate1";
            DropDownList1.DataBind();
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
    protected void DropDownList1_DataBound(object sender, EventArgs e)
    {
        DropDownList1.Items.Insert(0, new ListItem("-- Select --", "0"));
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try 
        {
            if (DropDownList1.SelectedValue != "0")
            { 
            DataGrid2.DataSource  =dh.GetsalesReport(DropDownList1.SelectedItem.ToString());
            DataGrid2.DataBind();
            
            }
        }
        catch (Exception ex)
        { 
        Message(ex.Message,true);
        }
    }
}