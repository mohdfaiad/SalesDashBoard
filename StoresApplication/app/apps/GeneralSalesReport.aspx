<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GeneralSalesReport.aspx.cs" Inherits="GeneralSalesReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style8
        {
            font-size: 14px;
            width: 32%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph2" Runat="Server">
    <div class="breadcrumb">
        &nbsp;</div>
    <div class="container">
        <div>
            <fieldset>
                <legend>General Sales Report</legend>
                <table cellpadding="5" cellspacing="0" 
                    class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                    <tr>
                        <td>
                            <table cellpadding="3" cellspacing="0" 
                                class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                                <tr>
                                    <td style="text-align: right">
                                                    <table class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTableCol5Table">
                                                        <tr>
                                                            <td class="style8">
                                                                Select&nbsp; Reporting Month</td>
                                                            <td class="style8">
                                                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                                                    Height="25px" ondatabound="DropDownList1_DataBound" 
                                                                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="119px">
                                                                </asp:DropDownList>
                                                            </td>
                                                            <td width="50%">
                                                                &nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                </tr>
                                <tr>
                                    <td style="text-align: left">
                                                <asp:DataGrid ID="DataGrid2" runat="server" CellPadding="4"
                                                    ForeColor="#333333" GridLines="None" Width="100%" 
                                            AllowPaging="True" Font-Bold="False"
                                                    Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"
                                                    PageSize="40">
                                                    <ItemStyle CssClass="GridItemStyle GridRows" Font-Size="10pt" />
                                                    <AlternatingItemStyle CssClass="GridAlternatingItemStyle GridRows" Font-Size="10pt" />
                                                    <HeaderStyle CssClass="GridHeaderStyle" />
                                                    <PagerStyle CssClass="GridPagerStyle" Mode="NumericPages" Visible="False" />
                                                    <FooterStyle CssClass="GridFooterStyle" />
                                                    <EditItemStyle CssClass="GridEditItemStyle" />
                                                    <SelectedItemStyle CssClass="GridSelectedItemStyle" />
                                                </asp:DataGrid>
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

