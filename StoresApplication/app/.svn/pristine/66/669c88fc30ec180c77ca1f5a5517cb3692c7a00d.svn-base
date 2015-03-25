<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MonthlyPerformance.aspx.cs" Inherits="MonthlyPerformance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .sampleTable
        {
            border-spacing: 0px;
            border-collapse: collapse;
            margin: 0px;
            padding: 2px;
            width: 467px;
            vertical-align: top;
            text-align: left;
            height: 300px;
        }
        
        .style5
        {
            font-size: 9pt;
            color: #1a3b69;
            width: 412px;
        }
        .style7
        {
            width: 100%;
            float: left;
        }
        .style8
        {
            width: 140px;
        }
        .style9
        {
            width: 140px;
        }
        .style10
        {
            width: 140px;
        }
        .style11
        {
            width:140px;
        }
        .style12
        {
            width: 140px;
        }
        .style13
        {
            float: left;
        }
        .style14
        {
            font-size: 12px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph2" Runat="Server">
    <div class="container">
        <div>
            <fieldset>
                <legend>Products Monthly Performance</legend>
                <table cellpadding="5" cellspacing="0" 
                    class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                    <tr>
                        <td>
                            <table cellpadding="3" cellspacing="0" 
                                class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                                <tr>
                                    <td style="text-align: right">
                                                &nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="text-align: right">
                                        <table align="left" width="100%">
                                            <tr>
                                                <td class="style8">
                                                    Select Filter Option
                                                </td>
                                                <td class="style9">
                                                <asp:DropDownList ID="cboSearchType" runat="server" Width="95%" AutoPostBack="True"
                                                    OnSelectedIndexChanged="cboSearchType_SelectedIndexChanged">
                                                    <asp:ListItem>-- Select --</asp:ListItem>
                                                    <asp:ListItem Value="ProductType">Product Type</asp:ListItem>
                                                    <asp:ListItem Value="Product">Product</asp:ListItem>
                                                    <asp:ListItem>Month</asp:ListItem>
                                                </asp:DropDownList>
                                                </td>
                                                <td class="style12">
                                                    SelectProduct Type</td>
                                                <td class="style11">
                                                <asp:DropDownList ID="cboSearchType0" runat="server" Width="95%" OnDataBound="ddlProductType_DataBound"
                                                    AutoPostBack="True" 
                                                        OnSelectedIndexChanged="ddlProductType_SelectedIndexChanged">
                                                </asp:DropDownList>
                                                </td>
                                                <td class="style10">
                                                    Select Product</td>
                                                <td>
                                                <asp:DropDownList ID="ddlProduct" runat="server" Width="95%" OnDataBound="ddlProduct_DataBound"
                                                    AutoPostBack="True" onselectedindexchanged="ddlProduct_SelectedIndexChanged">
                                                </asp:DropDownList>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: left">
            <table cellpadding="0" cellspacing="0" class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                <tr>
                    <td style="padding-top: 5px; padding-bottom: 5px">
                        <table cellpadding="0" cellspacing="0" class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                            <tr>
                                <td style="width: 30%; padding-right: 5px; text-align: left; vertical-align: top;">
                                    <table cellpadding="0" cellspacing="0" class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;<strong> <span class="style14">Top Performing Products</span></strong>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Chart ID="Chart7" runat="server" BackColor="243, 223, 193" Width="438px" Height="323px"
                                                    BorderlineDashStyle="Solid" BackGradientStyle="TopBottom" 
                                                    BorderWidth="2px" BorderColor="#B54001"
                                                    DataSourceID="TopItems">
                                                    <Titles>
                                                        <asp:Title ShadowColor="32, 0, 0, 0" Font="Trebuchet MS, 14.25pt, style=Bold" ShadowOffset="3"
                                                            Text="High Performing Products" Name="Products" ForeColor="26, 59, 105">
                                                        </asp:Title>
                                                    </Titles>
                                                    <Legends>
                                                        <asp:Legend TitleFont="Microsoft Sans Serif, 8pt, style=Bold" BackColor="Transparent"
                                                            Font="Trebuchet MS, 8.25pt, style=Bold" IsTextAutoFit="False" Enabled="False"
                                                            Name="Default">
                                                        </asp:Legend>
                                                    </Legends>
                                                    <Series>
                                                        <asp:Series Name="Series1" XValueMember="Description" YValueMembers="Profit" 
                                                            BorderColor="180, 26, 59, 105">
                                                        </asp:Series>
                                                    </Series>
                                                    <ChartAreas>
                                                        <asp:ChartArea Name="ChartArea1" BorderColor="#339966">
                                                            <AxisX LineColor="Gray">
                                                                <MajorGrid LineColor="LightGray" />
                                                            </AxisX>
                                                            <AxisY LineColor="Gray">
                                                                <MajorGrid LineColor="LightGray" />
                                                            </AxisY>
                                                        </asp:ChartArea>
                                                    </ChartAreas>
                                                </asp:Chart>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp; &nbsp;<asp:SqlDataSource ID="TopItems" runat="server" 
                                                    ConnectionString="<%$ ConnectionStrings:LOCALMACHINE5 %>" 
                                                    SelectCommand="getTopPerformingProductsbyCat" 
                                                    SelectCommandType="StoredProcedure">
                                                    <SelectParameters>
                                                        <asp:ControlParameter ControlID="cboSearchType0" Name="id" 
                                                            PropertyName="SelectedValue" Type="Int32" />
                                                    </SelectParameters>
                                                </asp:SqlDataSource>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblSelectedEmpFn0" runat="server" Text="Label" Visible="False"></asp:Label>
                                                <asp:Label ID="lblRatingSerial0" runat="server" Text="0" Visible="False"></asp:Label>
                                                <asp:Label ID="lblCommentToBeSaved0" runat="server" Text="Label" Visible="False"></asp:Label>
                                                <asp:Label ID="lblGroupID3" runat="server" Text="Label" Visible="False"></asp:Label>
                                                <asp:Label ID="lblGroupID4" runat="server" Text="Label" Visible="False" BorderStyle="None"></asp:Label>
                                                <asp:Label ID="lblIself0" runat="server" Text="Label" BorderStyle="None" Visible="False"></asp:Label>
                                                <asp:Label ID="lblIsSup0" runat="server" Text="Label" BorderStyle="None" Visible="False"></asp:Label>
                                                <asp:Label ID="lblIsHOD0" runat="server" Text="Label" BorderStyle="None" Visible="False"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td style="width: 70%; text-align: left; vertical-align: top; padding-left: 10px;">
                                    <table cellpadding="0" cellspacing="0" class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTable">
                                        <tr>
                                            <td style="text-align: left; vertical-align: top; padding-bottom: 5px">
                                                    <table class="ThirdTableRow5_FirstTableColumn3_FirstTableSecondTableCol5Table">
                                                        <tr>
                                                            <td class="style13">
                                                                Select Month</td>
                                                            <td width="50%">
                                                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                                                    Height="25px" ondatabound="DropDownList1_DataBound" 
                                                                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="119px">
                                                                </asp:DropDownList>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="style13" colspan="2">
                                                <asp:Label ID="Label5" runat="server" ForeColor="Black" 
                                                    style="font-weight: 700; font-size: 12px"></asp:Label>
                                                            </td>
                                                        </tr>
                                                    </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: left; vertical-align: top; padding-bottom: 5px">
                                                    <asp:DataGrid ID="DataGrid3" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                                        ForeColor="#333333" GridLines="None" Width="90%" AllowPaging="True" Font-Bold="False"
                                                        Font-Italic="False" Font-Overline="False" Font-Strikeout="False" 
                                                    Font-Underline="False" PageSize="9">
                                                        <ItemStyle CssClass="GridItemStyle GridRows" Font-Size="10pt" />
                                                        <AlternatingItemStyle CssClass="GridAlternatingItemStyle GridRows" Font-Size="10pt" />
                                                        <HeaderStyle CssClass="GridHeaderStyle" />
                                                        <PagerStyle CssClass="GridPagerStyle" Mode="NumericPages" Visible="False" />
                                                        <FooterStyle CssClass="GridFooterStyle" />
                                                        <EditItemStyle CssClass="GridEditItemStyle" />
                                                        <SelectedItemStyle CssClass="GridSelectedItemStyle" />
                                                        <Columns>
                                                            <asp:BoundColumn DataField="ReportDate" HeaderText="Rep Date">
                                                                <ItemStyle Width="20%" Font-Bold="False" Font-Italic="False" Font-Overline="False"
                                                                    Font-Strikeout="False" Font-Underline="False" Wrap="False" />
                                                            </asp:BoundColumn>
                                                            <asp:BoundColumn DataField="Product" HeaderText="Product"></asp:BoundColumn>
                                                            <asp:BoundColumn DataField="UnitsSold" HeaderText="Qty"></asp:BoundColumn>
                                                            <asp:BoundColumn DataField="Cost" HeaderText="Cost"></asp:BoundColumn>
                                                            <asp:BoundColumn DataField="Sales" HeaderText="Sales">
                                                                <ItemStyle Width="20%" />
                                                            </asp:BoundColumn>
                                                            <asp:ButtonColumn CommandName="view"  HeaderText="Profit" Text="Profit" ButtonType="PushButton" DataTextField="Profit" DataTextFormatString="{0:#,###,###.##}">
                                                                <ItemStyle CssClass="GridButtonColumnItemStyle" Font-Size="10pt" Width="10%" />
                                                            </asp:ButtonColumn>
                                                        </Columns>
                                                    </asp:DataGrid>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Label ID="lblSelectedEmpFn" runat="server" Text="Label" Visible="False"></asp:Label>
                                                <asp:Label ID="lblRatingSerial" runat="server" Text="0" Visible="False"></asp:Label>
                                                <asp:Label ID="lblCommentToBeSaved" runat="server" Text="Label" Visible="False"></asp:Label>
                                                <asp:Label ID="lblGroupID" runat="server" Text="Label" Visible="False"></asp:Label>
                                                <asp:Label ID="lblGroupID2" runat="server" Text="Label" Visible="False" BorderStyle="None"></asp:Label>
                                                <asp:Label ID="lblIself" runat="server" Text="Label" BorderStyle="None" Visible="False"></asp:Label>
                                                <asp:Label ID="lblIsSup" runat="server" Text="Label" BorderStyle="None" Visible="False"></asp:Label>
                                                <asp:Label ID="lblIsHOD" runat="server" Text="Label" BorderStyle="None" Visible="False"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: center">
                                                <asp:Label ID="Label6" runat="server" ForeColor="Black" 
                                                    style="font-weight: 700; font-size: 12px"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: center">
                                    <asp:DataGrid ID="DataGrid1" runat="server" CellPadding="4"
                                        ForeColor="#333333" GridLines="None" Width="99%" AllowPaging="True" Font-Bold="False"
                                        Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"
                                        PageSize="8">
                                        <ItemStyle CssClass="GridItemStyle GridRows" Font-Size="10pt" />
                                        <AlternatingItemStyle CssClass="GridAlternatingItemStyle GridRows" Font-Size="10pt" />
                                        <HeaderStyle CssClass="GridHeaderStyle" Font-Bold="True" Font-Italic="False" 
                                            Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
                                        <PagerStyle CssClass="GridPagerStyle" Mode="NumericPages" />
                                        <FooterStyle CssClass="GridFooterStyle" />
                                        <EditItemStyle CssClass="GridEditItemStyle" />
                                        <SelectedItemStyle CssClass="GridSelectedItemStyle" />
                                    </asp:DataGrid>
                                    </td>
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

