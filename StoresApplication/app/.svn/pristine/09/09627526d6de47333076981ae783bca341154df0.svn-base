<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddUser.aspx.cs" Inherits="AddUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph2" Runat="Server">
    <div class="breadcrumb">
        &nbsp;</div>
    <div class="container">
        <div>
            <fieldset>
                <legend>Add New User</legend>
                <table cellpadding="5" cellspacing="0" 
                    class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                    <tr>
                        <td>
                            <table cellpadding="3" cellspacing="0" 
                                class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                                <tr>
                                    <td style="text-align: right">
                                        &nbsp;<span class="style9" style="color: red">* indicates required fields.</span>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: left">
                                        <table cellpadding="0" cellspacing="0" class="style1">
                                            <tr>
                                                <td style="padding: 5px; text-align: right; width: 45%">
                                                    <asp:Label ID="lblOldPassword" runat="server" Text="First Name"></asp:Label>
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 45%">
                                                    <asp:TextBox ID="txtfname" runat="server" Width="95%"></asp:TextBox>
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 10%">
                                                    <asp:Label ID="lblRequired" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding: 5px; text-align: right; width: 45%">
                                                    Last Name</td>
                                                <td style="padding: 5px; text-align: left; width: 45%">
                                                    <asp:TextBox ID="txtlname" runat="server" Width="95%"></asp:TextBox>
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 10%">
                                                    <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding: 5px; text-align: right; width: 45%">
                                                    Access Level</td>
                                                <td style="padding: 5px; text-align: left; width: 45%">
                                                    <asp:DropDownList ID="ddlAccesslevel" runat="server" 
                                                        ondatabound="ddlAccesslevel_DataBound" Width="98%">
                                                    </asp:DropDownList>
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 10%">
                                                    <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="padding: 5px; text-align: right; width: 45%">
                                                    Is Active</td>
                                                <td style="padding: 5px; text-align: left; width: 45%">
                                                    <asp:CheckBox ID="chkActive" runat="server" Checked="True" />
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 10%">
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td style="padding: 5px; text-align: right; width: 45%">
                                                    &nbsp;</td>
                                                <td style="padding: 5px; text-align: left; width: 45%">
                                                    <asp:Button ID="BtnSave" runat="server" onclick="BtnSave_Click" Text="SAVE" 
                                                        Width="100px" />
                                                </td>
                                                <td style="padding: 5px; text-align: left; width: 10%">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblCodeNumber" runat="server" Text="Label" Visible="False"></asp:Label>
                                        <asp:Label ID="lblEmpSerial" runat="server" Text="0" Visible="False"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pop" Runat="Server">
</asp:Content>

