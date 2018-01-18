<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Workshop.aspx.cs" Inherits="Admin_Workshop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <table width="100%" style="font-weight: bold;">
            <tr>
                <td style="text-align: right; padding: 15px;"><b>Workshop Title : </b></td>
                <td>
                    <asp:TextBox ID="txtWorkshopTitle" runat="server" Width="150px" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td style="text-align: right; padding: 15px;"><b>Workshop Date : </b></td>
                <td>
                    <asp:TextBox ID="txtWorkshopDate" runat="server" Width="150px" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td style="text-align: right; padding: 15px;">Workshop Duration : </td>
                <td>
                    <asp:TextBox ID="txtWorkshopDuration" runat="server" Width="150px" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td style="text-align: right; padding: 15px;"><b>Workshop Topics : </b></td>
                <td>
                    <asp:TextBox ID="txtWorkshopTopics" Height="60px" runat="server" Width="150px" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td style="text-align: right; padding: 15px;">
                    <asp:Button ID="btnSave" runat="server" Text="Save" Font-Bold="True" OnClick="btnSave_Click" CssClass="btn btn-primary" />
                </td>
                <td>&nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="gvWorkshops" runat="server" CellPadding="10" ForeColor="#333333" GridLines="None" CellSpacing="5">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" Height="30px" HorizontalAlign="Center" Width="200px" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>

