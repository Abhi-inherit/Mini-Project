using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Admin;

namespace Buyit
{
    public partial class Login : System.Web.UI.Page
    {

        Admin adm = new Admin();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave(object sender, EventArgs e)
        {
            string x = Convert.ToString(eMail.Text);
            string y = Convert.ToString(TextBox1.Text);
            int z = adm.Login_Check(x, y);

            if (z == 1)
            {
                Response.Redirect(ResolveClientUrl("Admin_Pages/MainPage.aspx")); 
            }
            else
            {
                Label3.Text = "Check your E-Mail and Passeord and try again.";
            }
        }
    }
}