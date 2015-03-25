<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePass.aspx.cs" Inherits="ChangePass" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>STORES APP</title>

  
    <style type="text/css">
        body
        {
            margin: 0px;
           background: #f6f5fa url('images/page_bg.png');
            background-repeat: repeat-y;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 11px;
            line-height: 18px;
            height: 100%;
        }
        .wrapper
        {
            width: 100%;
            height: 472px;
            position: absolute;
            margin-top: 100px;
            background: url('images/loginheader_bg.png');
            background-repeat: repeat-x;
            height: 85px;
        }
        .header
        {
            background-image: url('images/3.jpg');
            width: 100%;
            height: 84px;
            background-repeat: no-repeat;
            background-position: center;
        }
        .loginbox
        {
            margin: 0em auto;
            width: 480px;
            border: 1px solid #fff;
            border-top: 0px;
            padding: 10px;
        }
        .textbox
        {
            background-color: #f5f5f5;
            border: 1px solid #ccc;
            padding: 3px;
            width: 220px;
        }
        .style1
        {
            width: 70%;
        }
    input[type=text], input[type=password]{
background-image: url('images/textbox_bg.png'); background-repeat: repeat-x; border: 1px solid #e1dada;
padding: 4px 5px;
}

input[type=button], input[type=submit]{
	background-image: url('images/btn_bg.png'); border: 1px solid #6799c6; padding: 5px 10px; color: #fff; font-weight: bold;
	 -moz-border-radius: 4px;
  border-radius: 4px;
  cursor: pointer

}
        .style2
        {
            width: 95%;
            font-size: 11px;
            font-family: Arial, Helvetica, sans-serif;
        }
        .style3
        {
            width: 100px;
            font-size: 11px;
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="wrapper">
            <div class="header">
                </div>
            <div class="loginbox">
                                        <table cellpadding="0" cellspacing="0" class="style1">
                                            <tr>
                                                <td style="padding: 5px; text-align: right; " colspan="3">
                                                    <asp:Label ID="Label5" runat="server" ForeColor="Red"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding: 5px; text-align: right; width: 45%">
                                                    &nbsp;</td>
                                                <td style="padding: 5px; text-align: left; width: 45%">
                                                    &nbsp;</td>
                                                <td style="padding: 5px; text-align: left; width: 10%">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="padding: 5px; text-align: right; width: 45%">
                                                    <asp:Label ID="lblOldPassword" runat="server" Text="Old Password"></asp:Label>
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 45%">
                                                    <asp:TextBox ID="txtoldpw" runat="server" Width="95%" TextMode="Password"></asp:TextBox>
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 10%">
                                                    <asp:Label ID="lblRequired" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding: 5px; text-align: right; width: 45%">
                                                    New Password</td>
                                                <td style="padding: 5px; text-align: left; width: 45%">
                                                    <asp:TextBox ID="txtnewpw" runat="server" Width="95%" TextMode="Password"></asp:TextBox>
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 10%">
                                                    <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding: 5px; text-align: right; width: 45%">
                                                    Confirm Password</td>
                                                <td style="padding: 5px; text-align: left; width: 45%">
                                                    <asp:TextBox ID="txtconfirmpw" runat="server" Width="95%" TextMode="Password"></asp:TextBox>
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 10%">
                                                    <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding: 5px; text-align: right; width: 45%">
                                                    &nbsp;</td>
                                                <td style="padding: 5px; text-align: left; width: 45%">
                                                    <asp:Button ID="BtnSave" runat="server" onclick="BtnSave_Click" 
                                                        Text="CHANGE" Width="100px" />
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 10%">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
            </div>
        </div>
        <div class="footer_logo">
           
            </div>
    </div>
    </form>
</body>
</html>