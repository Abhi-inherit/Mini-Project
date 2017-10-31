using BLL.Admin_Properties;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;



namespace BLL.Admin_Manager
{
    public class AdminLogin
    {
        DBHelper DB = new DBHelper();
        public BLL.Admin_Properties.ProductProperties productProperties = new BLL.Admin_Properties.ProductProperties();
        public BLL.Admin_Properties.CategoryProperties CatPro = new BLL.Admin_Properties.CategoryProperties();
        public BLL.Admin_Properties.BrandProperties brnd = new BLL.Admin_Properties.BrandProperties();
        public BLL.Admin_Properties.IndexProperties indexProperties = new BLL.Admin_Properties.IndexProperties();

        private SortedList s1 = new SortedList();

        public string LoginCheck() 
        {
            s1.Clear();
            s1.Add("Email",indexProperties.email);
            s1.Add("Password", indexProperties.password);
            return DB.ExecuteProcedure(s1, "LoginCheck");
        }

        public string BrandInsert()
        {
            s1.Clear();
            s1.Add("Brand_Name", brnd.brand);
            return DB.ExecuteProcedure(s1, "BrandInsert");
        }

        public string BrandEdit()
        {
            s1.Clear();
            s1.Add("Brand_ID", brnd.brand_id);
            s1.Add("Brand_name",brnd.brand);
            return DB.ExecuteProcedure(s1, "BrandEdit");
        }

        public string BrandDelete()
        {
            s1.Clear();
            s1.Add("Brand_ID", brnd.brand_id);
            return DB.ExecuteProcedure(s1, "BrandDelete");
        }

        public string CategoryInsert()
        {
            s1.Clear();
            s1.Add("mainCategory", CatPro.mainCategory);
            return DB.ExecuteProcedure(s1, "CategoryInsert");
        }

        public string MainCategoryEdit()
        {
            s1.Clear();
            s1.Add("Category_Name", CatPro.mainCategory);
            s1.Add("Category_ID", CatPro.mainCategoryID);
            return DB.ExecuteProcedure(s1, "MainCategoryEdit");
        }

        public string MAinCategoryDelete()
        {
            s1.Clear();
            s1.Add("Category_ID", CatPro.mainCategoryID);
            return DB.ExecuteProcedure(s1, "MAinCategoryDelete");
        }

        public string SubCategory1Insert()
        {
            s1.Clear();
            s1.Add("SubCategory1", CatPro.subCategory1);
            return DB.ExecuteProcedure(s1, "SubCategory1Insert");
        }

        public string SubCategory1Edit() 
        {
            s1.Clear();
            s1.Add("First_Category_Name", CatPro.subCategory1);
            s1.Add("First_Category_ID", CatPro.subCategory1_ID);
            return DB.ExecuteProcedure(s1,"SubCategory1Edit");
        }

        public string SubCategory1Delete()
        {
            s1.Clear();
            s1.Add("First_Category_ID", CatPro.subCategory1_ID);
            return DB.ExecuteProcedure(s1, "SubCategory1Delete");
        }

        public string SubCategory2Insert()
        {
            s1.Clear();
            s1.Add("SubCategory2", CatPro.subCategory2);
            return DB.ExecuteProcedure(s1, "SubCategory2Insert");
        }

        public string SubCategory2Edit()
        {
            s1.Clear();
            s1.Add("Second_Category_ID", CatPro.subCategory2_ID);
            s1.Add("Second_Category_Name", CatPro.subCategory2);
            return DB.ExecuteProcedure(s1, "SubCategory2Edit");
        }

        public string SubCategory2Delete()
        {
            s1.Clear();
            s1.Add("Second_Category_ID", CatPro.subCategory2_ID);
            return DB.ExecuteProcedure(s1, "SubCategory2Delete");
        }

        public string SubCategory3Insert()
        {
            s1.Clear();
            s1.Add("SubCategory3", CatPro.subCategory3);
            return DB.ExecuteProcedure(s1, "SubCategory3Insert");
        }

        public string SubCategory3Edit()
        {
            s1.Clear();
            s1.Add("Third_Category_ID", CatPro.subCategory3_ID);
            s1.Add("Third_Category_Name", CatPro.subCategory3);
            return DB.ExecuteProcedure(s1, "SubCategory3Edit");
        }

        public string SubCategory3Delete()
        {
            s1.Clear();
            s1.Add("Third_Category_ID", CatPro.subCategory3_ID);
            return DB.ExecuteProcedure(s1, "SubCategory3Delete");
        }

        public string ProductInsert()
        {
            s1.Clear();
            s1.Add("Product_Name",productProperties.productName);
            s1.Add("FK_Category_ID",productProperties.categoryID);
            s1.Add("FK_First_Category_ID",productProperties.subCategory1ID);
            s1.Add("FK_Second_Category_ID", productProperties.subCategory2ID);
            s1.Add("FK_Third_Category_ID", productProperties.subCategory3ID);
            s1.Add("Price", productProperties.price);
            s1.Add("FK_Brand_ID",productProperties.brandID);
            s1.Add("Description",productProperties.description);
            s1.Add("ImagePath",productProperties.filename);
            s1.Add("Qty",productProperties.quantity);
            return DB.ExecuteProcedure(s1, "ProductInsert");
        }

        public string ProductEdit()
        {
            s1.Clear();
            s1.Add("Product_ID", productProperties.productID);
            s1.Add("Product_Name", productProperties.productName);
            s1.Add("FK_Category_ID", productProperties.categoryID);
            s1.Add("FK_First_Category_ID", productProperties.subCategory1ID);
            s1.Add("FK_Second_Category_ID", productProperties.subCategory2ID);
            s1.Add("FK_Third_Category_ID", productProperties.subCategory3ID);
            s1.Add("Price", productProperties.price);
            s1.Add("FK_Brand_ID", productProperties.brandID);
            s1.Add("Description", productProperties.description);
            s1.Add("ImagePath", productProperties.filename);
            s1.Add("Qty", productProperties.quantity);
            return DB.ExecuteProcedure(s1, "ProductEdit");
        }

        public string ProductDelete() 
        {
            s1.Clear();
            s1.Add("Product_ID", productProperties.productID);
            return DB.ExecuteProcedure(s1, "ProductDelete");
        }

    }
}
