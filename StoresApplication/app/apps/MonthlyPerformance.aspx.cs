﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MonthlyPerformance : System.Web.UI.Page
{
    DatabaseHandler dh = new DatabaseHandler();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                GetProductType();
                cboSearchType.SelectedIndex = 3;
                cboSearchType0.SelectedValue = "1";
                defaultvalue();
                loadUniqdate();
            }
            //loadUniqdate();
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
    protected void ddlProductType_DataBound(object sender, EventArgs e)
    {
        cboSearchType0.Items.Insert(0, new ListItem("-- Select --", "0"));
    }

    protected void ddlProduct_DataBound(object sender, EventArgs e)
    {
        ddlProduct.Items.Insert(0, new ListItem("-- Select --", "0"));
    }
    protected void ddlProductType_SelectedIndexChanged(object sender, EventArgs e)
    {       
        try
        {
            if (cboSearchType0.SelectedValue == "0" || cboSearchType0.SelectedValue == "")
            {
                cboSearchType0.SelectedValue = "1";
            }
            DateTime date;
            if (DropDownList1.SelectedValue == "0" || DropDownList1.SelectedValue == "")
            {
                date = DateTime.Parse("June/1/2014 ");
            }
            else
            {
                date = DateTime.Parse(DropDownList1.SelectedValue);
            }
            ddlProduct.DataSource = dh.GetProductById(int.Parse(cboSearchType0.SelectedValue));
            ddlProduct.DataValueField = "ItemCode";
            ddlProduct.DataTextField = "Description";
            ddlProduct.DataBind();
            DataGrid3.DataSource = dh.GetItemsReport(int.Parse(cboSearchType0.SelectedValue), date);
            DataGrid3.DataBind();
            Label5.Text = "Sales for : " + cboSearchType0.SelectedItem.ToString();
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
        }
    }
    private void defaultvalue()
    {
        DateTime date;
        if (DropDownList1.SelectedValue == "0" || DropDownList1.SelectedValue == "")
        {
            date = DateTime.Parse("June/1/2014 ");
        }
        else
        {
            date = DateTime.Parse(DropDownList1.SelectedValue);
        }
        ddlProduct.DataSource = dh.GetProductById(int.Parse(cboSearchType0.SelectedValue));
        ddlProduct.DataValueField = "ItemCode";
        ddlProduct.DataTextField = "Description";
        ddlProduct.DataBind();
        DataGrid3.DataSource = dh.GetItemsReport(int.Parse(cboSearchType0.SelectedValue),date);
        DataGrid3.DataBind();
        Label5.Text = "Sales for : " + cboSearchType0.SelectedItem.ToString();
    }
    protected void cboSearchType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (cboSearchType.SelectedIndex == 0)
            {
                //Response.Redirect("PerformanceByProductType.aspx");
            }
            else if (cboSearchType.SelectedIndex == 1)
            {
                Response.Redirect("PerformanceByProductType.aspx");
            }
            else if (cboSearchType.SelectedIndex == 2 || cboSearchType.SelectedIndex == 3)
            {
                Response.Redirect("MonthlyPerformance.aspx");
            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
        }
    }
    protected void DropDownList1_DataBound(object sender, EventArgs e)
    {
        DropDownList1.Items.Insert(0, new ListItem("-- Select --", "0"));
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

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataGrid3.DataSource = dh.GetItemsReport(int.Parse(cboSearchType0.SelectedValue), DateTime.Parse(DropDownList1.SelectedValue));
            DataGrid3.DataBind();
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
        }
    }
    protected void ddlProduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (cboSearchType0.SelectedValue != "0")
            {
                DataGrid1.DataSource = dh.GetsalesDetails(ddlProduct.SelectedValue);
                DataGrid1.DataBind();
                Label6.Text = "All Sales for : " + ddlProduct.SelectedItem.ToString();
            }
            else
            {
                Message("Product Type has not been selected....", true);
            }
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
        }
    }
}