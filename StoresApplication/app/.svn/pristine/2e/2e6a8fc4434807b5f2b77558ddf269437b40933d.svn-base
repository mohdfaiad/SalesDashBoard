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

public partial class ChangePass : System.Web.UI.Page
{
    DatabaseHandler dh = new DatabaseHandler();
    Businesslogic bll = new Businesslogic();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {

            }
        }
        catch (Exception ex)
        {
            Label5.Text = ex.Message.ToString();
            Label5.Visible = true;
        }
    }



    // ************************* REGION NUMBER ONE *************************

    #region CLASS METHODS

    private void SavePassword()
    {
        Label5.Visible = true;
        if (txtnewpw.Text.Trim() == Session["UserName"].ToString())
        {
            Label5.Text="UserName and Password must be different";
          
        }
        else if (Session["PassWord"].ToString() != txtoldpw.Text)
        {
            Label5.Text = "The Old Password is your username";
            txtoldpw.Text = "";
        }
        else if (txtnewpw.Text.Trim() != txtconfirmpw.Text.Trim())
        {
            Label5.Text= "Passwords don't match";
            txtconfirmpw.Text = "";
        }
        else if (txtnewpw.Text.Trim() == "")
        {
            Label5.Text="Enter new password";
            txtconfirmpw.Text = "";
        }
        else
        {


            dh.Updatepassword(Session["UserName"].ToString(), Session["PassWord"].ToString(), txtnewpw.Text.Trim());
            Session["PassWord"] = txtnewpw.Text.Trim();
            Response.Redirect("DashBoard.aspx");
        }

    }
    #endregion

    // *************************   END   *************************



    // ************************* REGION NUMBER TWO *************************

    #region CLASS EVENTS (ASP.NET CONTROL EVENTS)

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        try
        {
            SavePassword();
        }
        catch (Exception ex)
        {
            Label5.Text = ex.Message.ToString();
            Label5.Visible = true;
        }
    }
 

    #endregion

    // *************************   END   *************************


}