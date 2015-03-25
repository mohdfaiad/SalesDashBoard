<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

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
            width: 40%;
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
                <table cellpadding="4" cellspacing="0" align="center">
                    <tr>
                        <td colspan="2" style="vertical-align: middle; text-align: center">
                        <asp:Label ID="lblmsg" runat="server" Font-Bold="True" 
                            Font-Size="8pt" ForeColor="Red" 
                            Text="System Message" 
                            Visible="False"></asp:Label>
                            &nbsp;
                            </td>
                    </tr>
                    <tr>
                        <td>
                            <strong>User ID:</strong>
                        </td>
                        <td>
                            <asp:TextBox ID="txtusername" runat="server" CssClass="textbox" Width="180"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <strong>Password:</strong>
                        </td>
                        <td>
                            <asp:TextBox ID="txtpassword" runat="server" CssClass="textbox" TextMode="Password" 
                                Width="180"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                            </td>
                        <td>
                            <asp:Button ID="BtnLogin" runat="server" CssClass="cusbuttton" 
                                onclick="BtnLogin_Click" 
                                Style="background-image: url('images/btn_bg_over.png'); border: 1px solid #6799c6; padding: 5px 10px; color: #fff; font-weight: bold; -moz-border-radius: 4px; border-radius: 4px; cursor: pointer" 
                                Text="Login" />
                            &nbsp;&nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            
                            <asp:LinkButton ID="forgetpass" runat="server"
                                Text="Forgot Password?" Style="margin-right: 40px; margin-bottom: 40px" 
                                onclick="forgetpass_Click" Visible="False"></asp:LinkButton>
                            
                            </td>
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