<%@ Page Title="" Language="C#" MasterPageFile="~/BuyItAdminMaster.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Buyit.Admin_Pages.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Admin_Style/Main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="AddProducts.aspx"><div class="addProducts"> Add Products</div></a>
    <a href="Category.aspx"><div class="addCategory"> Add Category</div></a>
    <a href="SubCategory.aspx"><div class="addSubCategory"> Add Sub-Category</div></a>
</asp:Content>
