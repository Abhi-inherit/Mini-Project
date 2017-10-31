<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="IndexAdmin.aspx.cs" Inherits="Buyit.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="index">

        <table style="margin:70px;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Txt_Email" runat="server" Height="30" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Txt_Password" runat="server" TextMode="Password" ToolTip="Characters case sensitive" Height="30" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Sign In" OnClick="Button1_Click" /><br />
                    <asp:Label ID="Lbl_Message" runat="server" Text="" ForeColor="#CC0000"></asp:Label>
                </td>
            </tr>
        </table>

    </div>

</asp:Content>
