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

        </table>
    </div>
</asp:Content>

