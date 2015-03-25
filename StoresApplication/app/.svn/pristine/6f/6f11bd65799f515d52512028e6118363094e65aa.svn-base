using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ItemCategories : System.Web.UI.Page
{
    DatabaseHandler dh = new DatabaseHandler();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if(!IsPostBack)
            {
                GetItemCategory();
                MultiView1.ActiveViewIndex = 0;
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
            saveCategories();
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
        }
    }
    private void saveCategories()
    {
        if (txtbuyingprice.Text.Trim() == "" || txtbuyingprice.Text.Trim() == ".")
        {
            Message("Enter unit buying cost", true);
        }
        else if (txtdescription.Text.Trim() == "")
        {
            Message("Product Description needed", true);
        }
        else if (DropDownList1.SelectedValue == "0")
        {
            Message("Select Product Type", true);
        }
        else if(txtItemcode.Text.Trim()=="")
        {
            Message("Product Code needed", true);
        }
        else
        {
        dh.SaveItemCategories(txtItemcode.Text.Trim(),txtdescription.Text.Trim(),int.Parse(DropDownList1.SelectedValue),decimal.Parse(txtbuyingprice.Text));
        Message("Details have been saved", true);
        clearcontrols();
        }
    }
    private void GetItemCategory()
    {
        DropDownList1.DataSource = dh.GetProductType();
        DropDownList1.DataValueField = "Id";
        DropDownList1.DataTextField = "Name";
        DropDownList1.DataBind();
    
    }
    private void clearcontrols()
    {
        txtbuyingprice.Text = "";
        txtdescription.Text = "";
        txtItemcode.Text = "";
    }
    protected void DropDownList1_DataBound(object sender, EventArgs e)
    {
        DropDownList1.Items.Insert(0, new ListItem("-- Select --", "0"));
    }
}