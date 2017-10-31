using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Admin;

namespace Buyit.Admin_Pages
{
    public partial class Category : System.Web.UI.Page
    {
        Admin al = new Admin();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave(object sender, EventArgs e)
        {
            al.catPro.category = 1;
        }
    }
}