<%@ Page Title="Manage Brand" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Enter_Brand.aspx.cs" Inherits="Buyit.Enter_Brand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="manageBrand">
     <br />
     <br />
     <br />
     <table style="margin:30px;">
         <tr>
             <td><asp:Label ID="Label1" runat="server" Text="Enter Brand"></asp:Label></td>
             <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
         </tr>
         <tr>
             <td></td>
             <td>
                 <asp:Button ID="Button1" runat="server" Text="Enter" OnClick="Button1_Click" /></td>
         </tr>
     </table>
     <asp:HiddenField ID="HiddenField1" runat="server" />
     <asp:HiddenField ID="HiddenField2" runat="server" />
     <br />

        <div style="margin-left:6%; overflow-y:scroll; height:200px; overflow-x:scroll; width:200px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Brand_ID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Brand_ID" HeaderText="ID" ReadOnly="True" SortExpression="Brand_ID" InsertVisible="False" />
                    <asp:BoundField DataField="Brand_Name" HeaderText="Brand" SortExpression="Brand_Name" />
                    <asp:TemplateField HeaderText="Edit">

                        <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton1" Onclick="Edit_Click" runat="server" ImageUrl="~/bootstrap/img/editimage.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">

                         <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton2" Onclick="Delete_Click" runat="server" ImageUrl="~/bootstrap/img/deleteicon.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT * FROM [Brand] WHERE ([Brand_Name] &lt;&gt; @Brand_Name) ORDER BY [Brand_Name]">
                <SelectParameters>
                    <asp:Parameter DefaultValue="----Select----" Name="Brand_Name" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>

        <br />
     
    </div>

</asp:Content>
