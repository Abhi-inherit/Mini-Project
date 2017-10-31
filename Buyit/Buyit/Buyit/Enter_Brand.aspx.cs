using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Admin_Manager;



namespace Buyit
{
    public partial class Enter_Brand : System.Web.UI.Page
    {

        AdminLogin Al = new AdminLogin();
        Admin ad = new Admin();

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (HiddenField2.Value != "")
            {
                Button1.Text = "Save";
                Al.brnd.brand = TextBox1.Text.Trim().ToString();
                Al.brnd.brand_id = Convert.ToInt32(HiddenField1.Value);
                Al.BrandDelete();
                TextBox1.Text = "";
                HiddenField1.Value = "";
                HiddenField2.Value = "";
                GridView1.DataBind();

            }
            else if (HiddenField1.Value != "")
            {
                Button1.Text = "Save";
                Al.brnd.brand = TextBox1.Text.Trim().ToString();
                Al.brnd.brand_id = Convert.ToInt32(HiddenField1.Value);
                Al.BrandEdit();
                HiddenField1.Value = "";
                GridView1.DataBind();
            }
            else
            {
                Al.brnd.brand = TextBox1.Text.Trim().ToString();
                Al.BrandInsert();
                GridView1.DataBind();
            }
        }

        protected void Edit_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            TextBox1.Text = grdow.Cells[1].Text;
            HiddenField1.Value = grdow.Cells[0].Text;
            Button1.Text = "Update";
        }

        protected void Delete_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imbtn = sender as ImageButton;
            GridViewRow grdow = imbtn.NamingContainer as GridViewRow;
            TextBox1.Text = grdow.Cells[1].Text;
            HiddenField1.Value = grdow.Cells[0].Text;
            HiddenField2.Value = "1";
            Button1.Text = "Delete";
        }




    }
}