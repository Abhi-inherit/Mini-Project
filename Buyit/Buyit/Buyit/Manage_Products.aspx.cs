using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BLL.Admin_Manager;
using System.IO;

namespace Buyit
{
    public partial class Manage_Products : System.Web.UI.Page
    {

        AdminLogin AL = new AdminLogin();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Session.Contents["Username"] == null)
                {
                    Response.Redirect("IndexAdmin.aspx");
                }
                else
                {


                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (DDL_Category1.SelectedItem.Text == "----Select----")
            //{
            //    DDL_Category1.SelectedItem.Value = "0";
            //}

            //if (DDL_Category2.SelectedItem.Text == "----Select----")
            //{
            //    DDL_Category2.SelectedItem.Value = "0";
            //}

            //if (DDL_Category3.SelectedItem.Text == "----Select----")
            //{
            //    DDL_Category3.SelectedItem.Value = "0";
            //}

            //if (DDL_Category4.SelectedItem.Text == "----Select----")
            //{
            //    DDL_Category4.SelectedItem.Value = "0";
            //}

            //if (DDL_Brand.SelectedItem.Text == "----Select----")
            //{
            //    DDL_Brand.SelectedItem.Value = "0";
            //}


            if (HiddenField_Edit.Value != "")
            {
                if (HiddenField_Delete.Value != "")
                {
                    AL.productProperties.productID = Convert.ToInt32(HiddenField_Edit.Value);
                    AL.ProductDelete();
                    GridView1.DataBind();
                    HiddenField_Edit.Value = "";
                    HiddenField_Delete.Value = "";
                    Button1.Text = "Save";
                }

                else
                {
                    AL.productProperties.productID = Convert.ToInt32(HiddenField_Edit.Value);
                    string filename1 = Path.GetFileName(fileuploadimages.PostedFile.FileName);
                    fileuploadimages.SaveAs(Server.MapPath("Images/" + fileuploadimages.FileName));
                    AL.productProperties.productName = TXT_Product_Name.Text.Trim().ToString();
                    AL.productProperties.filename = "Images/" + filename1;
                    AL.productProperties.categoryID = Convert.ToInt32(DDL_Category1.SelectedItem.Value);
                    AL.productProperties.subCategory1ID = Convert.ToInt32(DDL_Category2.SelectedItem.Value);
                    AL.productProperties.subCategory2ID = Convert.ToInt32(DDL_Category3.SelectedItem.Value);
                    AL.productProperties.subCategory3ID = Convert.ToInt32(DDL_Category4.SelectedItem.Value);
                    AL.productProperties.brandID = Convert.ToInt32(DDL_Brand.SelectedItem.Value);
                    AL.productProperties.price = Txt_Price.Text.Trim().ToString();
                    AL.productProperties.description = TXT_Description.InnerText.Trim().ToString();
                    AL.productProperties.quantity = Txt_Quantity.Text.Trim().ToString();
                    AL.ProductEdit();
                    GridView1.DataBind();
                    HiddenField_Edit.Value = "";
                    Button1.Text = "Save";
                }
            }

            else
            {
                string filename = Path.GetFileName(fileuploadimages.PostedFile.FileName);
                fileuploadimages.SaveAs(Server.MapPath("Images/" + fileuploadimages.FileName));
                AL.productProperties.productName = TXT_Product_Name.Text.Trim().ToString();
                AL.productProperties.filename = "Images/" + filename;
                AL.productProperties.categoryID = Convert.ToInt32(DDL_Category1.SelectedItem.Value);
                AL.productProperties.subCategory1ID = Convert.ToInt32(DDL_Category2.SelectedItem.Value);
                AL.productProperties.subCategory2ID = Convert.ToInt32(DDL_Category3.SelectedItem.Value);
                AL.productProperties.subCategory3ID = Convert.ToInt32(DDL_Category4.SelectedItem.Value);
                AL.productProperties.brandID = Convert.ToInt32(DDL_Brand.SelectedItem.Value);
                AL.productProperties.price = Txt_Price.Text.Trim().ToString();
                AL.productProperties.description = TXT_Description.InnerText.Trim().ToString();
                AL.productProperties.quantity = Txt_Quantity.Text.Trim().ToString();
                AL.ProductInsert();
            }
            Response.Redirect("Manage_Products.aspx");

            //http://www.aspdotnet-suresh.com/2011/03/how-to-save-images-into-folder-and.html

        }


        protected void Product_Edit(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            TXT_Product_Name.Text = grdow.Cells[3].Text;
            string x = Convert.ToString(grdow.Cells[4].Text);
            SqlDataSource1.SelectCommand = "SELECT Category_ID, Category_Name FROM Category ORDER BY CASE WHEN Category_Name = '" + x + "' THEN 0 ELSE 1 END ASC, Category_Name ASC";
            string y = Convert.ToString(grdow.Cells[5].Text);
            SqlDataSource3.SelectCommand = "SELECT First_Category_ID, First_Category_Name FROM First_Category ORDER BY CASE WHEN First_Category_Name = '" + y + "' THEN 0 ELSE 1 END ASC, First_Category_Name ASC";
            string z = Convert.ToString(grdow.Cells[6].Text);
            SqlDataSource4.SelectCommand = "SELECT Second_Category_ID, Second_Category_Name FROM Second_Category ORDER BY CASE WHEN Second_Category_Name = '" + z + "' THEN 0 ELSE 1 END ASC, Second_Category_Name ASC";
            string a = Convert.ToString(grdow.Cells[7].Text);
            SqlDataSource5.SelectCommand = "SELECT Third_Category_ID, Third_Category_Name FROM Third_Category ORDER BY CASE WHEN Third_Category_Name = '" + a + "' THEN 0 ELSE 1 END ASC, Third_Category_Name ASC";
            string b = Convert.ToString(grdow.Cells[9].Text);
            SqlDataSource2.SelectCommand = "SELECT Brand_ID, Brand_Name FROM Brand ORDER BY CASE WHEN Brand_Name = '" + b + "' THEN 0 ELSE 1 END ASC, Brand_Name ASC";
            TXT_Description.InnerText = grdow.Cells[12].Text;
            Txt_Quantity.Text = grdow.Cells[11].Text;
            Txt_Price.Text = grdow.Cells[8].Text;
            HiddenField_Edit.Value = grdow.Cells[0].Text; ;
            Button1.Text = "Update";

        }

        protected void Product_Delete(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            TXT_Product_Name.Text = grdow.Cells[3].Text;
            string x = Convert.ToString(grdow.Cells[4].Text);
            SqlDataSource1.SelectCommand = "SELECT Category_ID, Category_Name FROM Category ORDER BY CASE WHEN Category_Name = '" + x + "' THEN 0 ELSE 1 END ASC, Category_Name ASC";
            string y = Convert.ToString(grdow.Cells[5].Text);
            SqlDataSource3.SelectCommand = "SELECT First_Category_ID, First_Category_Name FROM First_Category ORDER BY CASE WHEN First_Category_Name = '" + y + "' THEN 0 ELSE 1 END ASC, First_Category_Name ASC";
            string z = Convert.ToString(grdow.Cells[6].Text);
            SqlDataSource4.SelectCommand = "SELECT Second_Category_ID, Second_Category_Name FROM Second_Category ORDER BY CASE WHEN Second_Category_Name = '" + z + "' THEN 0 ELSE 1 END ASC, Second_Category_Name ASC";
            string a = Convert.ToString(grdow.Cells[7].Text);
            SqlDataSource5.SelectCommand = "SELECT Third_Category_ID, Third_Category_Name FROM Third_Category ORDER BY CASE WHEN Third_Category_Name = '" + a + "' THEN 0 ELSE 1 END ASC, Third_Category_Name ASC";
            string b = Convert.ToString(grdow.Cells[9].Text);
            SqlDataSource2.SelectCommand = "SELECT Brand_ID, Brand_Name FROM Brand ORDER BY CASE WHEN Brand_Name = '" + b + "' THEN 0 ELSE 1 END ASC, Brand_Name ASC";
            TXT_Description.InnerText = grdow.Cells[12].Text;
            Txt_Quantity.Text = grdow.Cells[11].Text;
            Txt_Price.Text = grdow.Cells[8].Text;
            HiddenField_Edit.Value = grdow.Cells[0].Text; ;
            HiddenField_Delete.Value = "1";
            Button1.Text = "Delete";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String a = "";
            String b = "";
            String c = "";
            String d = "";
            String ee = "";
            String f = "";
            String g = "";
            String h = "";
            String i = "";
            String j = "";

            if (Ser_Product_Name.Text!="")
            {
                Ser_Product_Name.Text.Trim().ToString();
                a = "%"+Ser_Product_Name.Text+"%";
            }
            else if (Ser_Category.Text!="")
            {
                Ser_Category.Text.Trim().ToString();
                b = "%" + Ser_Category.Text + "%";
            }
            else if (Ser_sub1.Text!="")
            {
                Ser_sub1.Text.Trim().ToString();
                c = "%" + Ser_sub1.Text + "%";
            }
            else if (Ser_sub2.Text!="") 
            {
                Ser_sub2.Text.Trim().ToString();
                d = "%" + Ser_sub2.Text + "%";
            }
            else if (Ser_Sub3.Text!="")
            {
                Ser_Sub3.Text.Trim().ToString();
                ee = "%" + Ser_Sub3.Text + "%";
            }
            else if (Ser_Price.Text != "")
            {
                Ser_Price.Text.Trim().ToString();
                f = "%" + Ser_Price.Text + "%";
            }
            else if (Ser_Brand.Text != "")
            {
                Ser_Brand.Text.Trim().ToString();
                g = "%" + Ser_Brand.Text + "%";
            }
            else if (Ser_Qty.Text != "")
            {
                Ser_Qty.Text.Trim().ToString();
                h = "%" + Ser_Qty.Text + "%";
            }
            else if (Ser_Description.Text != "")
            {
                Ser_Description.Text.Trim().ToString();
                i = "%" + Ser_Description.Text + "%";
            }
            else 
            {
            }

            //AL.productProperties.serProduct = Ser_Product_Name.Text.Trim().ToString();
            //AL.productProperties.serCategory = Ser_Category.Text.Trim().ToString();
            //AL.productProperties.serSubCat1 = Ser_sub1.Text.Trim().ToString();
            //AL.productProperties.serSubCat2 = Ser_sub2.Text.Trim().ToString();
            //AL.productProperties.serSubCat3 = Ser_Sub3.Text.Trim().ToString();
            //AL.productProperties.serPrice = Ser_Price.Text.Trim().ToString();
            //AL.productProperties.serBrand = Ser_Brand.Text.Trim().ToString();
            //AL.productProperties.serQty = Ser_Qty.Text.Trim().ToString();
            //AL.productProperties.serDescription = Ser_Description.Text.Trim().ToString();

            SqlDataSource6.SelectCommand = "SELECT Product_ID, Product_Name, Category_Name, First_Category_Name, Second_Category_Name, Third_Category_Name, Price,Brand_Name,ImagePath,Qty,Description FROM ProductView WHERE (Product_Name LIKE '" + a + "') OR (Category_Name LIKE '" + b + "') OR (First_Category_Name LIKE '" + c + "') OR (Second_Category_Name LIKE '" + d + "') OR(Third_Category_Name LIKE '" + ee + "') OR(Price LIKE '" + f + "') OR(Brand_Name LIKE '" + g + "') OR (ImagePath LIKE '" + j + "') Or(Qty LIKE '" + h + "') OR (Description LIKE '" + i + "') ORDER BY Product_Name;";


        }


    }
}