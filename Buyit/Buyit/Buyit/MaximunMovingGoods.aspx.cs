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
    public partial class MaximunMovingGoods : System.Web.UI.Page
    {
        UserInterface UI = new UserInterface();
        private string tbl;

        protected void Page_Load(object sender, EventArgs e)
        {
            IDictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary = UI.SelectStockDetails();
            List<KeyValuePair<String, int>> MyList = dictionary.ToList();
            MyList.Sort((x,y)=>x.Value.CompareTo(y.Value));
            MyList.Reverse();
            tbl += "<table border=\"1\"><tr><td ><p>Braches</p></td><td ><p>StockIssue</p></td></tr>";
            foreach (KeyValuePair<String, int> pair in MyList)
            {
                //Console.WriteLine("Key:{0} Values:{0}", pair.Key, pair.Value);
                tbl += "<tr><td ><p>" + pair.Key + "</p></td><td ><p>" + pair.Value + "</p></td></tr>";
            }
            tbl += "</table>";
            tbl1.InnerHtml = tbl;
        }
    }
}