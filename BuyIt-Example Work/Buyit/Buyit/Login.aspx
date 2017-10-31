<%@ Page Title="" Language="C#" MasterPageFile="~/BuyItAdminMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Buyit.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="login2"><br />&nbsp&nbsp&nbsp
        <asp:Label ID="Label1" runat="server" Text="E-Mail"></asp:Label>
        <asp:TextBox ID="eMail" runat="server" ValidationGroup="a"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="eMail" ValidationGroup="a" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br /><br />
       

        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="a" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ValidationGroup="a" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br /><br />
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:Button ID="Button1" runat="server" Text="Log in" ValidationGroup="a" OnClick="BtnSave"/>
        <br /><br />

        <asp:Label ID="Label3" runat="server" ForeColor="#CC0000"></asp:Label>

    </div>

</asp:Content>
