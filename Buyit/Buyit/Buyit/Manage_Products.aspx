<%@ Page Title="Manage Product" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Manage_Products.aspx.cs" Inherits="Buyit.Manage_Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="productSearch">
         <table>
             <tr>
                 <td><br />&nbsp&nbsp&nbsp&nbsp 
                     <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="Enter details for product search"></asp:Label>
                 </td> 
                 
             </tr>  
         </table>
        <table>
            <tr>

                <td>
                    <br />&nbsp&nbsp&nbsp&nbsp
                    <asp:Label ID="Label5" runat="server" Text="Product Name"></asp:Label>
                    <br />&nbsp&nbsp&nbsp&nbsp
                    <asp:TextBox ID="Ser_Product_Name" runat="server" Width="100px"></asp:TextBox>
                </td>

                 <td>
                    <br />
                     <asp:Label ID="Label6" runat="server" Text="Category"></asp:Label><br />
                    <asp:TextBox ID="Ser_Category" runat="server" Width="100px"></asp:TextBox>
                </td>
                 <td>
                     <br />
                     <asp:Label ID="Label7" runat="server" Text="Sub category 1"></asp:Label><br />
                    <asp:TextBox ID="Ser_sub1" runat="server" Width="100px"></asp:TextBox>
                </td>
                 <td>
                     <br />
                     <asp:Label ID="Label8" runat="server" Text="Sub category 2"></asp:Label><br />
                    <asp:TextBox ID="Ser_sub2" runat="server" Width="100px"></asp:TextBox>
                </td>
                 <td>
                     <br />
                     <asp:Label ID="Label9" runat="server" Text="Sub category 3"></asp:Label><br />
                    <asp:TextBox ID="Ser_Sub3" runat="server" Width="100px"></asp:TextBox>
                </td>
                 <td>
                     <br />
                     <asp:Label ID="Label10" runat="server" Text="Price"></asp:Label><br />
                    <asp:TextBox ID="Ser_Price" runat="server" Width="50px"></asp:TextBox>
                </td>
                 <td>
                    <br />
                     <asp:Label ID="Label11" runat="server" Text="Brand"></asp:Label><br />
                    <asp:TextBox ID="Ser_Brand" runat="server" Width="100px"></asp:TextBox>
                </td>
                 <td>
                     <br />
                     <asp:Label ID="Label12" runat="server" Text="QTY"></asp:Label><br />
                    <asp:TextBox ID="Ser_Qty" runat="server" Width="50px"></asp:TextBox>
                </td>
                
            </tr>
            </table>
         <table>
             <tr>
                 <td>&nbsp&nbsp&nbsp&nbsp
                        <asp:Label ID="Label13" runat="server" Text="Description"></asp:Label>&nbsp&nbsp&nbsp&nbsp
                        <asp:TextBox ID="Ser_Description" runat="server"></asp:TextBox>
                 </td> 
                 <td>&nbsp&nbsp&nbsp&nbsp
                     <asp:Button ID="Button2" runat="server" Text="Search" Width="100px" OnClick="Button2_Click"/>
                 </td>
             </tr>  
         </table>
        

    </div>

    <div class="manageProducts">
        <asp:HiddenField ID="HiddenField_Edit" runat="server" />
        <asp:HiddenField ID="HiddenField_Delete" runat="server" />
        <br /><br /><br />
      <table>
          <tr>
              <td>
<br />&nbsp&nbsp&nbsp&nbsp 
                     <asp:Label ID="Label15" runat="server" Font-Bold="True" Text="Add products"></asp:Label><br /><br />
              </td>
          </tr> 
          <tr>
              <td>&nbsp&nbsp&nbsp&nbsp
                 
                  <asp:Label ID="Label1" runat="server" Text="Product Name"></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="TXT_Product_Name" runat="server"></asp:TextBox>
              </td>
          </tr>
           <tr>
              <td>&nbsp&nbsp&nbsp&nbsp
                  <asp:Label ID="Label2" runat="server" Text="Product Image"></asp:Label>
              </td>
              <td>
                  <asp:FileUpload ID="fileuploadimages" runat="server" />
              </td>
          </tr>
          <tr>
              <td>&nbsp&nbsp&nbsp&nbsp
                  Category 1
              </td>
              <td>
                  <asp:DropDownList ID="DDL_Category1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Category_Name" DataValueField="Category_ID"></asp:DropDownList>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
              </td>
          </tr>
          <tr>
              <td>&nbsp&nbsp&nbsp&nbsp
                  Category 2
              </td>
              <td>
                  <asp:DropDownList ID="DDL_Category2" runat="server" DataSourceID="SqlDataSource3" DataTextField="First_Category_Name" DataValueField="First_Category_ID"></asp:DropDownList>
                  <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT * FROM [First_Category]"></asp:SqlDataSource>
              </td>
          </tr>
          <tr>
              <td>&nbsp&nbsp&nbsp&nbsp
                  Category 3
              </td>
              <td>
                  <asp:DropDownList ID="DDL_Category3" runat="server" DataSourceID="SqlDataSource4" DataTextField="Second_Category_Name" DataValueField="Second_Category_ID"></asp:DropDownList>
                  <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT * FROM [Second_Category]"></asp:SqlDataSource>
              </td>
          </tr>
          <tr>
              <td>&nbsp&nbsp&nbsp&nbsp
                  Category 4
              </td>
              <td>
                  <asp:DropDownList ID="DDL_Category4" runat="server" DataSourceID="SqlDataSource5" DataTextField="Third_Category_Name" DataValueField="Third_Category_ID"></asp:DropDownList>
                  <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT * FROM [Third_Category]"></asp:SqlDataSource>
              </td>
          </tr>
          <tr>
              <td>&nbsp&nbsp&nbsp&nbsp
                  Brand
              </td>
              <td>
                  <asp:DropDownList ID="DDL_Brand" runat="server" DataSourceID="SqlDataSource2" DataTextField="Brand_Name" DataValueField="Brand_ID"></asp:DropDownList>
                  <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT * FROM [Brand]"></asp:SqlDataSource>
              </td>
          </tr>
          <tr>
              <td>&nbsp&nbsp&nbsp&nbsp
                  Description
              </td>
              <td>
                  <textarea id="TXT_Description" runat="server" cols="40" rows="4"></textarea>
              </td>
          </tr>

           <tr>
              <td>&nbsp&nbsp&nbsp&nbsp
                  <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="Txt_Quantity" runat="server"></asp:TextBox>
              </td>
          </tr>

          <tr>
              <td>&nbsp&nbsp&nbsp&nbsp
                  <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="Txt_Price" runat="server"></asp:TextBox>
              </td>
          </tr>

          <tr>
              <td>
                  
              </td>
              <td>
                  <asp:Button ID="Button1" runat="server" Text="Save" onclick="btnSubmit_Click"/>
              </td>
          </tr>

<%--<div>
<asp:GridView runat="server" ID="gvImages" AutoGenerateColumns="false" DataSourceID="sqldataImages" CssClass="Gridview" HeaderStyle-BackColor="#61A6F8" >
<Columns>
<asp:BoundField DataField="ID" HeaderText="ID" />
<asp:BoundField DataField="ImageName" HeaderText="Image Name" />
<asp:ImageField HeaderText="Image" DataImageUrlField="ImagePath" />
</Columns>
</asp:GridView>
<asp:SqlDataSource ID="sqldataImages" runat="server"  ConnectionString="<%$ConnectionStrings:dbconnection %>"
SelectCommand="select * from ImagesPath" >
</asp:SqlDataSource>
</div>--%>

      </table>
        <br /><br /><br />
    </div>

   

    <div class="ProductGridView">
          <br /><br />
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Product_ID" DataSourceID="SqlDataSource6">
            <Columns>
                <asp:BoundField DataField="Product_ID" HeaderText="ID" ReadOnly="True" SortExpression="Product_ID" >
                <HeaderStyle Font-Bold="True" />
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton1" OnClick="Product_Edit" runat="server" ImageUrl="~/bootstrap/img/editimage.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton2" OnClick="Product_Delete" runat="server" ImageUrl="~/bootstrap/img/deleteicon.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Product_Name" HeaderText="Product name" SortExpression="Product_Name" />
                <asp:BoundField DataField="Category_Name" HeaderText="Category" SortExpression="Category_Name" />
                <asp:BoundField DataField="First_Category_Name" HeaderText="Sub category 1" SortExpression="First_Category_Name" />
                <asp:BoundField DataField="Second_Category_Name" HeaderText="Sub category 2" SortExpression="Second_Category_Name" />
                <asp:BoundField DataField="Third_Category_Name" HeaderText="Sub category 3" SortExpression="Third_Category_Name" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:BoundField DataField="Brand_Name" HeaderText="Brand" SortExpression="Brand_Name" >
                <ItemStyle HorizontalAlign="Justify" />
                </asp:BoundField>
                <asp:ImageField HeaderText="Image" DataImageUrlField="ImagePath" >
                    <ControlStyle Height="80px" Width="80px" />
                    <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:ImageField>
<%--                <asp:BoundField DataField="ImagePath" HeaderText="ImagePath" SortExpression="ImagePath" />--%>
                <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                
                
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT [Product_ID], [Product_Name], [Category_Name], [First_Category_Name], [Second_Category_Name], [Third_Category_Name], [Price], [Brand_Name], [ImagePath], [Qty], [Description] FROM [ProductView]"></asp:SqlDataSource>
        &nbsp&nbsp&nbsp&nbsp
          <br /><br />
    </div>

</asp:Content>
