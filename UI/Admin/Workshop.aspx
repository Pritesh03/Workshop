<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Workshop.aspx.cs" Inherits="Admin_Workshop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
      
    </style>
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
                <td style="text-align: right; padding: 15px; text-align:center;" colspan="2">
                    <asp:Button ID="btnSave" runat="server" Text="Save" Font-Bold="True" OnClick="btnSave_Click" CssClass="btn btn-primary" Width="120px" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" Font-Bold="True" CssClass="btn btn-info" Width="120px" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" Font-Bold="True" CssClass="btn btn-danger" Width="120px" OnClick="btnDelete_Click" />
                </td>
                <td class="auto-style1">&nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:GridView ID="gvWorkshops" runat="server" CellPadding="10" ForeColor="#333333" GridLines="None" CellSpacing="5" AutoGenerateSelectButton="True" AutoGenerateColumns="False" style="margin:auto;" DataKeyNames="WorkshopId" OnSelectedIndexChanged="gvWorkshops_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="WorkshopId" HeaderText="Workshop Id">
                            <HeaderStyle Width="200px" />
                            <ItemStyle Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="WorkshopTitle" HeaderText="Workshop Title">
                            <HeaderStyle Width="200px" />
                            <ItemStyle Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="WorkshopDate" DataFormatString="{0:dd/MMM/yyyy}" HeaderText="Workshop Date">
                            <HeaderStyle Width="200px" />
                            <ItemStyle Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="WorkshopDuration" HeaderText="Workshop Duration">
                            <HeaderStyle Width="200px" />
                            <ItemStyle Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="WorkshopTopics" HeaderText="Workshop Topics">
                            <HeaderStyle Width="200px" />
                            <ItemStyle Width="200px" />
                            </asp:BoundField>
                        </Columns>
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

