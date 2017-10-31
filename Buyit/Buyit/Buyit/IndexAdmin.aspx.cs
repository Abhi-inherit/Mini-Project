using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BLL.Admin_Manager;

namespace Buyit
{
    public partial class Index : System.Web.UI.Page
    {
        AdminLogin AL = new AdminLogin();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Session.Clear();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AL.indexProperties.email = Txt_Email.Text.Trim().ToString();
            AL.indexProperties.password = Txt_Password.Text.Trim().ToString();
            string result = AL.LoginCheck();
            if (result == "Exists")
            {
                Session.Add("Username", Txt_Email.Text);
                Response.Redirect("Manage_Products.aspx");

            }
            else
            {
                Lbl_Message.Text = "Please enter a valid mail id and password.";
            }
        }
    }
}