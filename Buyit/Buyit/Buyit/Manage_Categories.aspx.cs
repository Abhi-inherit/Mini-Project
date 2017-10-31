using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BLL.Admin_Manager;
using BLL.Admin_Properties;


namespace Buyit
{
    public partial class Manage_Categories : System.Web.UI.Page
    {

        AdminLogin Al = new AdminLogin();

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

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            if (HF_MainCategory.Value != "")
            {
                if (HF_Delete.Value == "1")
                {
                   // Al.CatPro.mainCategory = MainCategory.Text.Trim().ToString();
                    Al.CatPro.mainCategoryID = Convert.ToInt32(HF_MainCategory.Value);
                    HF_MainCategory.Value = "";
                    HF_Delete.Value = "";
                    string result = Al.MAinCategoryDelete();
                    GridView1.DataBind();
                    MainCategory.Text = "";
                    Button1.Text = "Save";

                }
                else
                {
                    Al.CatPro.mainCategory = MainCategory.Text.Trim().ToString();
                    Al.CatPro.mainCategoryID = Convert.ToInt32(HF_MainCategory.Value);
                    HF_MainCategory.Value = "";
                    Al.MainCategoryEdit();
                    GridView1.DataBind();
                    Button1.Text = "Save";
                    
                }
            }

            else if (HF_subCategory1.Value!="")
           {
               if (HF_Delete.Value == "1")
               {
                  // Al.CatPro.subCategory1 = SubCategory1.Text.Trim().ToString();
                   Al.CatPro.subCategory1_ID = Convert.ToInt32(HF_subCategory1.Value);
                   HF_subCategory1.Value = "";
                   HF_Delete.Value = "";
                   Al.SubCategory1Delete();
                   GridView2.DataBind();
                   SubCategory1.Text = "";
                   Button1.Text = "Save";
               }
                    else
               {
                   Al.CatPro.subCategory1 = SubCategory1.Text.Trim().ToString();
                   Al.CatPro.subCategory1_ID = Convert.ToInt32(HF_subCategory1.Value);
                   HF_subCategory1.Value = "";
                   Al.SubCategory1Edit();
                   GridView2.DataBind();
                   Button1.Text = "Save";
                   SubCategory1.Text = "";
               }
           
           }
               
            else if (HF_subCategory2.Value!="")
            {
                if (HF_Delete.Value == "1")
                {
                    Al.CatPro.subCategory2_ID = Convert.ToInt32(HF_subCategory2.Value);
                    HF_subCategory2.Value = "";
                    HF_Delete.Value = "";
                    Al.SubCategory2Delete();
                    GridView3.DataBind();
                    Button1.Text = "Save";
                    SubCategory2.Text = "";
                }
                else
                {
                    Al.CatPro.subCategory2 = SubCategory2.Text.Trim().ToString();
                    Al.CatPro.subCategory2_ID = Convert.ToInt32(HF_subCategory2.Value);
                    HF_subCategory2.Value = "";
                    Al.SubCategory2Edit();
                    GridView3.DataBind();
                    Button1.Text = "Save";
                    SubCategory2.Text = "";
                }
            }

            else if (HF_subCategory3.Value != "")
            {
                if (HF_Delete.Value == "1")
                {
                    Al.CatPro.subCategory3_ID = Convert.ToInt32(HF_subCategory3.Value);
                    HF_subCategory3.Value = "";
                    HF_Delete.Value = "";
                    Al.SubCategory3Delete();
                    GridView4.DataBind();
                    Button1.Text = "Save";
                    SubCategory3.Text = "";
                }
                else
                {
                    Al.CatPro.subCategory3 = SubCategory3.Text.Trim().ToString();
                    Al.CatPro.subCategory3_ID = Convert.ToInt32(HF_subCategory3.Value);
                    HF_subCategory3.Value = "";
                    Al.SubCategory3Edit();
                    GridView4.DataBind();
                    Button1.Text = "Save";
                    SubCategory3.Text = "";
                }
            }

            else
            {

                if (MainCategory.Text != "")
                {
                    Al.CatPro.mainCategory = MainCategory.Text.Trim().ToString();
                    string result = Al.CategoryInsert();
                    //LblMainCategory.Text = result;
                    GridView1.DataBind();
                }

                if (SubCategory1.Text != "")
                {
                    Al.CatPro.subCategory1 = SubCategory1.Text.Trim().ToString();
                    string result = Al.SubCategory1Insert();
                    //LblSubCategory1.Text = result;
                    GridView2.DataBind();
                }

                if (SubCategory2.Text != "")
                {
                    Al.CatPro.subCategory2 = SubCategory2.Text.Trim().ToString();
                    string result = Al.SubCategory2Insert();
                    //LblSubCategory2.Text = result;
                    GridView3.DataBind();
                }

                if (SubCategory3.Text != "")
                {
                    Al.CatPro.subCategory3 = SubCategory3.Text.Trim().ToString();
                    string result = Al.SubCategory3Insert();
                    //LblSubCategory3.Text = result;
                    GridView4.DataBind();
                }
            }
        }

        protected void MainCategory_edit(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            MainCategory.Text = grdow.Cells[1].Text;
            HF_MainCategory.Value = grdow.Cells[0].Text;
            Button1.Text = "Update";
        }

        protected void MainCategory_delete(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            MainCategory.Text = grdow.Cells[1].Text;
            HF_MainCategory.Value = grdow.Cells[0].Text;
            HF_Delete.Value = "1";
            Button1.Text = "Delete";
        }

        protected void SubCategory1_edit(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            SubCategory1.Text = grdow.Cells[1].Text;
            HF_subCategory1.Value = grdow.Cells[0].Text;
            Button1.Text = "Update";
        }

        protected void SubCategory1_delete(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            SubCategory1.Text = grdow.Cells[1].Text;
            HF_subCategory1.Value = grdow.Cells[0].Text;
            HF_Delete.Value = "1";
            Button1.Text = "Delete";
        }

        protected void SubCategory2_edit(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            SubCategory2.Text = grdow.Cells[1].Text;
            HF_subCategory2.Value = grdow.Cells[0].Text;
            Button1.Text = "Update";
        }

        protected void SubCategory2_delete(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            SubCategory2.Text = grdow.Cells[1].Text;
            HF_subCategory2.Value = grdow.Cells[0].Text;
            HF_Delete.Value = "1";
            Button1.Text = "Delete";
        }

        protected void SubCategory3_edit(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            SubCategory3.Text = grdow.Cells[1].Text;
            HF_subCategory3.Value = grdow.Cells[0].Text;
            Button1.Text = "Update";
        }

        protected void SubCategory3_delete(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            SubCategory3.Text = grdow.Cells[1].Text;
            HF_subCategory3.Value = grdow.Cells[0].Text;
            HF_Delete.Value = "1";
            Button1.Text = "Delete";
        }
       

       
      


    }
}