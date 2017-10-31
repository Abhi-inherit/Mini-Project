using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using BLL.Admin_Manager;
using BLL.Admin_Properties;

namespace Buyit
{
    public partial class mens : System.Web.UI.Page
    {
        string html = "";
        string html2 = "";
        UserInterface UI = new UserInterface();

        protected void Page_Load(object sender, EventArgs e)
        {
            MensCategory();
            WomensCategory();
        }

        public void MensCategory()
        {
            html = "";
            html2 = "";

            List<CategoryProperties> _list = UI.SelectFirstCategory();

            for (int i = 0; i < _list.Count; i++)
            {
                if (i >= 8)
                {
                    html2 += "<li><a href = mens.aspx>" + _list[i].subCategory1 + "</a></li>";
                }
                else
                {
                    html += "<li><a href = mens.aspx>" + _list[i].subCategory1 + "</a></li>";
                }
            }
            FirstCategoryID_1_Men.InnerHtml = html;
            FirstCategoryID_2_Men.InnerHtml = html2;
        }

        public void WomensCategory()
        {
            html = "";
            html2 = "";

            List<CategoryProperties> _list = UI.SelectFirstCategory();

            for (int i = 0; i < _list.Count; i++)
            {
                if (i >= 8)
                {
                    html2 += "<li runat='server'><a href=womens.aspx>" + _list[i].subCategory1 + "</a></li>";
                }
                else
                {
                    html += "<li runat='server'><a href=womens.aspx>" + _list[i].subCategory1 + "</a></li>";
                }
            }
            FirstCategoryID_1_Women.InnerHtml = html;
            FirstCategoryID_2_Women.InnerHtml = html2;
        }
    }
}