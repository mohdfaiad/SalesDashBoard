using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddUser : System.Web.UI.Page
{
    DatabaseHandler dh = new DatabaseHandler();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                GetAccessLevel();
            }

        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
        }
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        try
        {
            string username = txtfname.Text.Substring(0, 1) + txtlname.Text.Trim();
            string password = username;
            dh.SaveUser(username.ToLower(), txtfname.Text.Trim(), txtlname.Text.Trim(), password.ToLower(), int.Parse(ddlAccesslevel.SelectedValue), true);
            ClearControls();
            Message("User Details Saved", true);
        }
        catch (Exception ex)
        {
            Message(ex.Message, true);
        }
    }

    private void ClearControls()
    {
        txtfname.Text = "";
        txtlname.Text = "";
        ddlAccesslevel.SelectedIndex = -1;
    }
    private void Message(string GetMessage, bool ColorRed)
    {
        Label msg = (Label)Master.FindControl("lblmsg");
        msg.Visible = true;
        if (ColorRed == true) { msg.ForeColor = System.Drawing.Color.Red; msg.Font.Bold = true; }
        else { msg.ForeColor = System.Drawing.Color.Blue; msg.Font.Bold = true; }
        msg.Text = "MESSAGE:  ............" + GetMessage + "............";
    }

    private void GetAccessLevel()
    {
        ddlAccesslevel.DataSource = dh.GetAccesslevels();
        ddlAccesslevel.DataValueField = "Id";
        ddlAccesslevel.DataTextField = "Name";
        ddlAccesslevel.DataBind();
    }

    protected void ddlAccesslevel_DataBound(object sender, EventArgs e)
    {
        ddlAccesslevel.Items.Insert(0, new ListItem("-- Select --", "0"));
    }
}