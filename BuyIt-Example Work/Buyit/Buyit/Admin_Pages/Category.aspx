<%@ Page Title="" Language="C#" MasterPageFile="~/BuyItAdminMaster.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="Buyit.Admin_Pages.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Category">
        <br />&nbsp&nbsp&nbsp
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
       <br/>&nbsp&nbsp&nbsp
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="btnSave" />
    </div>

</asp:Content>
