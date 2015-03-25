using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Login : System.Web.UI.Page
{
    DatabaseHandler dh = new DatabaseHandler();
    Businesslogic bll = new Businesslogic();
    DataTable dt = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        lblmsg.Visible = false;

        try
        {
            if (!IsPostBack)
            {
            
            }
        }
        catch (Exception ex)
        {
            lblmsg.Visible = true;
            lblmsg.Text = ex.Message;
        }
    }

    #region CLASS METHODS

    private void GetUser(string username, string password)
    {
        dt = dh.GetUser(username, password);
        int countrows = dt.Rows.Count;

        if (countrows != 0)
        {
           
            foreach (DataRow dr in dt.Rows)
            {
                Session["UserID"] = dr["Id"].ToString();
                Session["Accesslevel"] = dr["Accesslevel"].ToString();
                Session["UserName"] = dr["UserName"].ToString();
                Session["accesslevelname"] = "SYSTEM ACCOUNT";
                Session["FullName"] = dr["FullName"].ToString();
                Session["PassWord"] = dr["Password"].ToString();
                string AL = Session["Accesslevel"].ToString();
                if(username== password)
                {
                    Response.Redirect("ChangePass.aspx");
                }
                else
                {
                if (AL == "1" || AL == "2")
                {
                    Response.Redirect("DashBoard.aspx");
                }
                else if (AL == "3")
                {
                    Response.Redirect("DashBoard.aspx");
                }
                }
            }
        }
        else
        {
            if (username == "admin" && password == "123")
            {
                Session["UserID"] = "1000";
                Session["Accesslevel"] = "1";
                Session["UserName"] = "admin";
                Session["accesslevelname"] = "SYSTEM ACCOUNT";
                Session["PassWord"] = "123";
                Response.Redirect("DashBoard.aspx");
            }
            else
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Invalid Login... Check UserName OR Password";
            }
        }
    }


    #endregion

    #region CLASS EVENTS (ASP.NET CONTROL EVENTS)

    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtusername.Text.Trim() == "") 
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Please Enter the Username";
            }
            else if (txtpassword.Text.Trim() == "")
            {
                lblmsg.Visible = true;
                lblmsg.Text = "Please Enter the Password";
            }
            else 
            {
                string un = txtusername.Text.Trim();
                string pw = txtpassword.Text.Trim();
               GetUser(un, pw);
               
            }
        }
        catch (Exception ex)
        {
            lblmsg.Visible = true;
            lblmsg.Text = ex.Message;
        }
    }

    protected void forgetpass_Click(object sender, EventArgs e)
    {
        Response.Redirect("ForgetRecover.aspx");
    }

    #endregion


}