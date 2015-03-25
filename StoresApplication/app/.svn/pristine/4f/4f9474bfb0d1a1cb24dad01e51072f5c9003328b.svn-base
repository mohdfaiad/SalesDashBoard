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

public partial class MasterPage2 : System.Web.UI.MasterPage
{
    DatabaseHandler dac = new DatabaseHandler();
    Businesslogic bll = new Businesslogic();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if ((Session["UserName"] == null))
            {
                Response.Redirect("AddUser.aspx");
            }

            Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
            Response.Expires = -1500;
            Response.CacheControl = "no-cache";

            // Display Login Details......
            lblUser.Text = "Welcome : " + Session["FullName"].ToString().ToUpper();

        }
        catch (NullReferenceException)
        {
            Response.Redirect("Login.aspx");
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }
    }

    protected void lnkLogout_Click(object sender, EventArgs e)
    {
        try
        {
            Session["UserName"] = null;
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }
    }

    protected void lnkHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainHR.aspx");
    }
}
