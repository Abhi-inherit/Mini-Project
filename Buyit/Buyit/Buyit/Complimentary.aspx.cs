using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Admin_Manager;
using BLL.Admin_Properties;

namespace Buyit
{
    public partial class Complimentary : System.Web.UI.Page
    {
        private string html;
        private string html2;
        private string tbl;
        private string x;
        UserInterface UI = new UserInterface();

        protected void Page_Load(object sender, EventArgs e)
        {
            html = "";
            html2 = "";

            List<CategoryProperties> Branch = UI.SelectBranches();
            List<CategoryProperties> Item = UI.SelectItems();
            
            
            //tis is for trial
            //for (int i = 0; i < Item.Count; i++)
            //{
            //    html2 += "<li>" + Item[i].Item + "</a></li>";
            //}

            //item
            tbl += "<table border=\"1\"><tr><td ><p>Items</p></td>";
             
            //Branches Incriments
            for (int i = 0; i < Branch.Count; i++)
            {
                tbl += "<td><p>" + Branch[i].Branch + "</p></td> ";
            }
            tbl += "</tr><tr>";

            //Item starting
            for (int i = 0; i < Item.Count; i++)
            {
                tbl += "<td><p>" + Item[i].Item + "</p></td>";

                for (int l = 0; l < Branch.Count; l++)
                {

                    if (Item.ElementAtOrDefault(i) == null)
                    {
                        string h = "";
                        x = UI.StockDetail(Branch[l].Branch, h);
                        tbl += "<td><p>" + x + "</p></td>";
                    }
                    else
                    {
                        if (Branch.ElementAtOrDefault(l) == null)
                        {
                            string h = "";
                            x = UI.StockDetail(h, Item[i].Item);
                            tbl += "<td><p>" + x + "</p></td>";
                        }
                        else
                        {
                             x = UI.StockDetail(Branch[l].Branch, Item[i].Item);
                            tbl += "<td><p>" + x + "</p></td>";
                        }
                    }
                }
                tbl += "</tr>";
            }tbl += "</table>";

            FirstCategoryID_1_Men.InnerHtml = html;
            FirstCategoryID_2_Men.InnerHtml = html2;
            tbl1.InnerHtml = tbl;
        }
    }
}