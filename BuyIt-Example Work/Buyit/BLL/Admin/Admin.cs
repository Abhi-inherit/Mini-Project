using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.AdminProperties;


namespace BLL.Admin
{
    public class Admin
    {
        BLL.AdminProperties.CategoryProperties catPro = new BLL.AdminProperties.CategoryProperties();
        DBHelper db = new DBHelper();

        public int Login_Check(string eMail, string password)
        {
            int x = db.Check(eMail, password);
            return x;
        }
    }
}
