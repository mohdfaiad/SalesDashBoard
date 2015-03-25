using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PerformanceByProductType : System.Web.UI.Page
{
    DatabaseHandler dh = new DatabaseHandler();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Label msg = (Label)Master.FindControl("lblmsg");
            msg.Visible = false;

            if (IsPostBack == false)
            {
                cboSearchType.SelectedIndex = 1;
                GetProductType();
                GetTopPerformingTypes();
                //cboSearchType0.SelectedIndex = 1;
                GetByProductType();
            }
            //GetProductType();
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

    private void GetProductType()
    {
        try
        {
            cboSearchType0.DataSource = dh.GetProductType();
            cboSearchType0.DataValueField = "Id";
            cboSearchType0.DataTextField = "Name";
            cboSearchType0.DataBind();
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);

        }
    }
    private void GetByProductType()
    {
        if (cboSearchType0.SelectedValue == "0" || cboSearchType0.SelectedValue == "")
        {
            cboSearchType0.SelectedValue = "1";
        }
        DataGrid2.DataSource = dh.GetByProductType(int.Parse(cboSearchType0.SelectedValue));
        DataGrid2.DataBind();
        Label5.Text = "Monthly Performance of: " + cboSearchType0.SelectedItem.ToString();
        Label6.Text = "Top performing: " + cboSearchType0.SelectedItem.ToString();
    }
    private void GetTopPerformingTypes()
    {
        DataGrid1.DataSource = dh.GetTopPerformingTypes();
        DataGrid1.DataBind();
    }
    protected void cboSearchType0_DataBound(object sender, EventArgs e)
    {
        cboSearchType0.Items.Insert(0, new ListItem("-- Select --", "0"));
    }
    protected void cboSearchType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cboSearchType.SelectedIndex == 0)
        {
            //Response.Redirect("PerformanceByProductType.aspx");
        }
        else if (cboSearchType.SelectedIndex == 1)
        {
            //Response.Redirect("MonthlyPerformance.aspx");
        }
        else if (cboSearchType.SelectedIndex == 2 || cboSearchType.SelectedIndex == 3)
        {
            Response.Redirect("MonthlyPerformance.aspx");
        }
        else
        { 
        
        }
    }
    protected void cboSearchType0_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            GetByProductType();
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
        }
    }
}