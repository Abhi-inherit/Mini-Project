<%@ Page Title="Manage Categories" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Manage_Categories.aspx.cs" Inherits="Buyit.Manage_Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="manageCategories">
        <br /><br /><br />
        <table border="0">

            <tr>
                <td> 
                    Main Category  &nbsp
                </td>
                <td>
                    <asp:TextBox ID="MainCategory" runat="server" ValidationGroup="a"></asp:TextBox>
                </td>
                <td>
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="MainCategory" ForeColor="#CC0000" ValidationGroup="a" Font-Bold="True" Font-Size="Large"></asp:RequiredFieldValidator>--%>
                   <%-- <asp:Label ID="LblMainCategory" runat="server" ForeColor="Red"></asp:Label>--%> 
                    
                </td>
               
            </tr>

            <tr>
                <td>
                    Sub-Category 1 &nbsp
                </td>
                <td>
                    <asp:TextBox ID="SubCategory1" runat="server" ValidationGroup="a" ></asp:TextBox>
                </td>
                <td>
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" Font-Size="Larger" ValidationGroup="a" ControlToValidate="SubCategory1" ForeColor="#CC0000" Font-Bold="True"></asp:RequiredFieldValidator>--%>
                   
                    <%--<asp:Label ID="LblSubCategory1" runat="server" ForeColor="Red"></asp:Label>--%>
                </td>
            </tr>

            <tr>
                <td>
                    Sub-Category 2 &nbsp
                </td>
                <td>
                    <asp:TextBox ID="SubCategory2" runat="server"></asp:TextBox>
                </td>
                <td>
                     &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                   <%-- <asp:Label ID="LblSubCategory2" runat="server" ForeColor="Red"></asp:Label>--%>
                </td>
            </tr>

            <tr>
                <td>
                    Sub-Category 3  &nbsp
                </td>
                <td>
                    <asp:TextBox ID="SubCategory3" runat="server"></asp:TextBox>
                </td>
                <td>
                     &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                   <%-- <asp:Label ID="LblSubCategory3" runat="server" ForeColor="Red"></asp:Label>--%>
                </td>
            </tr>
            
            <tr>
                <td>

                </td>
                <td>
                   &nbsp&nbsp&nbsp&nbsp&nbsp
                   &nbsp&nbsp&nbsp&nbsp&nbsp
                   &nbsp&nbsp&nbsp&nbsp&nbsp 
                   <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Btn_Submit_Click" ValidationGroup="a" />
                </td>
            </tr>

        </table>
        <br />

         <asp:HiddenField ID="HF_MainCategory" runat="server" />
        <asp:HiddenField ID="HF_Delete" runat="server" />
        <div style="margin-left:6%; overflow-y:scroll; height:200px; overflow-x:scroll; width:200px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Category_ID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Category_ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="Category_ID" />
                    <asp:BoundField DataField="Category_Name" HeaderText="Category" SortExpression="Category_Name" />
                    <asp:TemplateField HeaderText="Edit">

                        <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton1" Onclick="MainCategory_edit" runat="server" ImageUrl="~/bootstrap/img/editimage.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">

                        <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton2" Onclick="MainCategory_delete" runat="server" ImageUrl="~/bootstrap/img/deleteicon.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT * FROM [Category] WHERE ([Category_Name] &lt;&gt; @Category_Name) ORDER BY [Category_Name]">
                <SelectParameters>
                    <asp:Parameter DefaultValue="----Select----" Name="Category_Name" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>

        <br />

        <asp:HiddenField ID="HF_subCategory1" runat="server" />
        <div style="margin-left:50%; margin-top:-41%; overflow-y:scroll; height:200px; overflow-x:scroll; width:200px;">
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="First_Category_ID" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="First_Category_ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="First_Category_ID" />
                    <asp:BoundField DataField="First_Category_Name" HeaderText="Sub category 1" SortExpression="First_Category_Name" />
                    <asp:TemplateField HeaderText="Edit">

                        <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton3" Onclick="SubCategory1_edit" runat="server" ImageUrl="~/bootstrap/img/editimage.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">

                        <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton4" Onclick="SubCategory1_delete" runat="server" ImageUrl="~/bootstrap/img/deleteicon.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT * FROM [First_Category] WHERE ([First_Category_Name] &lt;&gt; @First_Category_Name) ORDER BY [First_Category_Name]">
                <SelectParameters>
                    <asp:Parameter DefaultValue="----Select----" Name="First_Category_Name" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>

        <br />

        <asp:HiddenField ID="HF_subCategory2" runat="server" />
         <div style="margin-left:6%; overflow-y:scroll; height:200px; overflow-x:scroll; width:200px;">
             <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="Second_Category_ID" DataSourceID="SqlDataSource3">
                 <Columns>
                     <asp:BoundField DataField="Second_Category_ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="Second_Category_ID" />
                     <asp:BoundField DataField="Second_Category_Name" HeaderText="Sub category 2" SortExpression="Second_Category_Name" />
                     <asp:TemplateField HeaderText="Edit">

                         <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton5" Onclick="SubCategory2_edit" runat="server" ImageUrl="~/bootstrap/img/editimage.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>

                     </asp:TemplateField>
                     <asp:TemplateField HeaderText="Delete">

                         <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton6" Onclick="SubCategory2_delete" runat="server" ImageUrl="~/bootstrap/img/deleteicon.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>

                     </asp:TemplateField>
                 </Columns>
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT * FROM [Second_Category] WHERE ([Second_Category_Name] &lt;&gt; @Second_Category_Name) ORDER BY [Second_Category_Name]">
                 <SelectParameters>
                     <asp:Parameter DefaultValue="----Select----" Name="Second_Category_Name" Type="String" />
                 </SelectParameters>
             </asp:SqlDataSource>
         </div>

        <br />
       
        <asp:HiddenField ID="HF_subCategory3" runat="server" />
        <div style="margin-left:50%; margin-top:-41%; overflow-y:scroll; height:200px; overflow-x:scroll; width:200px;">
            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="Third_Category_ID" DataSourceID="SqlDataSource4">
                <Columns>
                    <asp:BoundField DataField="Third_Category_ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="Third_Category_ID" />
                    <asp:BoundField DataField="Third_Category_Name" HeaderText="Sub category 3" SortExpression="Third_Category_Name" />
                    <asp:TemplateField HeaderText="Edit">

                        <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton7" Onclick="SubCategory3_edit" runat="server" ImageUrl="~/bootstrap/img/editimage.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">

                        <ItemTemplate> 
                   <div>
                         <asp:ImageButton ImageAlign="Middle" ID="ImageButton8" Onclick="SubCategory3_delete" runat="server" ImageUrl="~/bootstrap/img/deleteicon.jpg" Height="20px" Width="20px"/>
                    </div>
                        </ItemTemplate>

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:BuyitConnectionString %>" SelectCommand="SELECT * FROM [Third_Category] WHERE ([Third_Category_Name] &lt;&gt; @Third_Category_Name) ORDER BY [Third_Category_Name]">
                <SelectParameters>
                    <asp:Parameter DefaultValue="----Select----" Name="Third_Category_Name" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>

        <br />

    </div>

    

</asp:Content>
