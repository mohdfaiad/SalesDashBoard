<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ReportUpload.aspx.cs" Inherits="ReportUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style5
        {
            color: #CC0000;
        }
        .style6
        {
            line-height: 115%;
            font-family: Arial, sans-serif;
            color: #4b4494;
            text-align: left;
            font-weight: bolder;
            font-size: 30px;
            height: 60px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph2" Runat="Server">
    <div class="breadcrumb">
    <table cellpadding="0" cellspacing="0" 
            class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
        <tr>
            <td style="vertical-align: top; text-align: left; width: 33%">
                &nbsp;</td>
            <td style="vertical-align: top; text-align: center; width: 33%">
                                                                &nbsp;</td>
            <td style="vertical-align: top; text-align: right; width: 33%">
                <span style="color: red" class="style9">* indicates required fields.</span></td>
        </tr>
    </table>
</div>
<div class="container">
    <table cellpadding="0" cellspacing="0" 
            class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
        <tr>
            <td style="vertical-align: top; text-align: center; width: 100%; padding-bottom: 30px;">
                <div>
                    <fieldset>
                        <legend>UPLOAD DATA FROM BRANCHES</legend>
                        <table cellpadding="5" cellspacing="0" 
                                class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                            <tr>
                                <td>
                                    <table cellpadding="3" cellspacing="0" 
                                            class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                                        <tr>
                                            <td style="text-align: left">
                                                <table cellpadding="0" cellspacing="0" 
                                                        class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                                                    <tr>
                                                        <td style="vertical-align: top; text-align: center; ">
                                                            &nbsp;</td>
                                                    </tr>
                                                    <tr>
                                                        <td style="vertical-align: top; text-align: center; ">
                                                            <table class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable" 
                                                                width="70%">
                                                                <tr>
                                                                    <td style="text-align: right">
                                                                        Store </td>
                                                                    <td style="text-align: left">
                                                                        <asp:DropDownList ID="ddlbranch" runat="server" 
                                                                            ondatabound="ddlbranch_DataBound" ForeColor="Blue">
                                                                        </asp:DropDownList>
                                                                    </td>
                                                                    <td style="text-align: right">
                                                                        Month </td>
                                                                    <td style="text-align: left">
                                                                        <asp:DropDownList ID="ddlMonth" runat="server" ondatabound="ddlMonth_DataBound" 
                                                                            ForeColor="Blue">
                                                                            <asp:ListItem>-- Select --</asp:ListItem>
                                                                            <asp:ListItem>JANUARY</asp:ListItem>
                                                                            <asp:ListItem>FEBRUARY</asp:ListItem>
                                                                            <asp:ListItem>MARCH</asp:ListItem>
                                                                            <asp:ListItem>APRIL</asp:ListItem>
                                                                            <asp:ListItem>MAY</asp:ListItem>
                                                                            <asp:ListItem>JUNE</asp:ListItem>
                                                                            <asp:ListItem>JULY</asp:ListItem>
                                                                            <asp:ListItem>AUGUST</asp:ListItem>
                                                                            <asp:ListItem>SEMPTEMBER</asp:ListItem>
                                                                            <asp:ListItem>OCTOBER</asp:ListItem>
                                                                            <asp:ListItem>NOVEMBER</asp:ListItem>
                                                                            <asp:ListItem>DECEMBER</asp:ListItem>
                                                                        </asp:DropDownList>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td 
                                                                
                                                                style="padding: 20px 0px 0px 0px; vertical-align: top; text-align: center; ">
                                                            <div __designer:mapid="1">
                                                                <fieldset __designer:mapid="2">
                                                                    <legend __designer:mapid="3">UPLOAD SECTION</legend>
                                                                    <table __designer:mapid="4" cellpadding="5" cellspacing="0" 
                                                                            class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                                                                        <tr __designer:mapid="5">
                                                                            <td __designer:mapid="6">
                                                                                <table cellpadding="0" cellspacing="0" 
                                            class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                                                                                    <tr>
                                                                                        <td style="padding: 20px 0px 0px 0px; vertical-align: top; text-align: center; ">
                                                                                            <table align ="center" cellpadding="0" cellspacing="0" style="width: 84%" >
                                                                                                <tr>
                                                                                                    <td style="padding: 5px; text-align: center; " colspan="3">
                                                                                                        <strong><span class="style5"><span class="style3">&nbsp;Excel File format is 
                                                                                                        expected&nbsp; </span>
                                                                                                        <p class="style6">
                                                                                                            &nbsp;Only *.xls or *.xlsx file format</p>
                                                                                                        </span></strong>
                                                                                                    </td>
                                                                                                </tr>
                                                                                                <tr>
                                                                                                    <td style="padding: 5px; text-align: right; width: 30%">
                                                                                                        Browse Report
                                                                                                    </td>
                                                                                                    <td style="padding: 5px; text-align: left; width: 60%">
                                                                                                        <asp:FileUpload ID="FileUpload1" runat="server" 
                                                                                                            CssClass="InterfaceDropdownList" Width="80%" />
                                                                                                    </td>
                                                                                                    <td style="padding: 5px; text-align: left; width: 10%">
                                                                                                        <asp:Label ID="Label42" runat="server" ForeColor="Red" Text="*"></asp:Label>
                                                                                                    </td>
                                                                                                </tr>
                                                                                            </table>
                                                                                        </td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td style="padding: 20px 0px 0px 0px; vertical-align: top; text-align: center; ">
                                                                                            <asp:Button ID="BtnSave" runat="server" onclick="BtnSave_Click" 
                                                        Text="UPLOAD REPORT" Width="150px" 
                                                        
                                                        
                                                        
                                                        onclientclick="return confirm('Are you sure you want to post this Task?')" />
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </fieldset>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblTrainingID" runat="server" Text="Label" Visible="False"></asp:Label>
                                                <asp:Label ID="lblSave" runat="server" Text="save" Visible="False"></asp:Label>
                                                <asp:Label ID="lblEmpSerial" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="lblCVName" runat="server" Text="Label" Visible="False"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </div>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top; text-align: center; width: 100%; padding-bottom: 30px;">
                    &nbsp;</td>
        </tr>
    </table>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pop" Runat="Server">
</asp:Content>

