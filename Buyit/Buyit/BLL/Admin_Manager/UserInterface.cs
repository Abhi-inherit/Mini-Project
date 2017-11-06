using BLL.Admin_Properties;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace BLL.Admin_Manager
{
    public class UserInterface
    {
        DBHelper DB = new DBHelper();
        public BLL.Admin_Properties.CategoryProperties CatPro = new BLL.Admin_Properties.CategoryProperties();
        private SortedList s1 = new SortedList();


        public List<CategoryProperties> SelectFirstCategory()
        {

            DataTable dt = new DataTable();
            dt = DB.getdatatable("SelectFirstCategory");
            List<CategoryProperties> _list = new List<CategoryProperties>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new CategoryProperties
                            {
                                subCategory1_ID = Convert.ToInt32(dr["First_Category_ID"]),
                                subCategory1 = dr["First_Category_Name"].ToString()
                            }
                         );
            }

            return _list;

        }

        public string StockDetail(string branch, string item)
        {
            s1.Clear();
            s1.Add("Branch", branch);
            s1.Add("Item", item);
            return DB.ExecuteProcedure(s1, "StockItem");
        }

        public List<CategoryProperties> SelectBranches()
        {
            DataTable dt = new DataTable();
            dt = DB.getdatatable("SelectBranches");
            List<CategoryProperties> _list = new List<CategoryProperties>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new CategoryProperties
                {
                    Branch = dr["BranchName"].ToString()
                }
                );
            }
            return _list;
        }

        public List<CategoryProperties> SelectItems()
        {
            DataTable dt = new DataTable();
            dt = DB.getdatatable("SelectCompliItems");
            List<CategoryProperties> _list = new List<CategoryProperties>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new CategoryProperties
                {
                    Item = dr["ItemName"].ToString()
                }
                );
            }
            return _list;
        }

        public List<ProductProperties> SelectMensProducts()
        {
            DataTable dt = new DataTable();
            dt = DB.getdatatable("SelectMensProducts");
            List<ProductProperties> _list = new List<ProductProperties>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new ProductProperties
                {
                    productID = Convert.ToInt32(dr["Product_ID"]),
                    productName = dr["Product_Name"].ToString(),
                    categoryID = Convert.ToInt32(dr["FK_Category_ID"]),
                    categoryName = dr["Category_Name"].ToString(),
                    subCategory1ID = Convert.ToInt32(dr["FK_First_Category_ID"]),
                    FirstcategoryName = dr["First_Category_Name"].ToString(),
                    subCategory2ID = Convert.ToInt32(dr["FK_Second_Category_ID"]),
                    SecondcategoryName = dr["Second_Category_Name"].ToString(),
                    subCategory3ID = Convert.ToInt32(dr["FK_Third_Category_ID"]),
                    ThirdcategoryName = dr["Third_Category_Name"].ToString(),
                    price = dr["Price"].ToString(),
                    brandID = Convert.ToInt32(dr["FK_Brand_ID"]),
                    BrandName = dr["Brand_Name"].ToString(),
                    ImagePath = dr["ImagePath"].ToString(),
                    quantity = dr["Qty"].ToString(),
                    description = dr["Description"].ToString()
                });
            }

            return _list;
        }

        public List<ProductProperties> SelectWomensProducts()
        {
            DataTable dt = new DataTable();
            dt = DB.getdatatable("SelectWomenProducts");
            List<ProductProperties> _list = new List<ProductProperties>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new ProductProperties
                {
                    productID = Convert.ToInt32(dr["Product_ID"]),
                    productName = dr["Product_Name"].ToString(),
                    categoryID = Convert.ToInt32(dr["FK_Category_ID"]),
                    categoryName = dr["Category_Name"].ToString(),
                    subCategory1ID = Convert.ToInt32(dr["FK_First_Category_ID"]),
                    FirstcategoryName = dr["First_Category_Name"].ToString(),
                    subCategory2ID = Convert.ToInt32(dr["FK_Second_Category_ID"]),
                    SecondcategoryName = dr["Second_Category_Name"].ToString(),
                    subCategory3ID = Convert.ToInt32(dr["FK_Third_Category_ID"]),
                    ThirdcategoryName = dr["Third_Category_Name"].ToString(),
                    price = dr["Price"].ToString(),
                    brandID = Convert.ToInt32(dr["FK_Brand_ID"]),
                    BrandName = dr["Brand_Name"].ToString(),
                    ImagePath = dr["ImagePath"].ToString(),
                    quantity = dr["Qty"].ToString(),
                    description = dr["Description"].ToString()
                });
            }

            return _list;
        }

        public List<ProductProperties> SelectBagProducts()
        {
            DataTable dt = new DataTable();
            dt = DB.getdatatable("SelectBagProducts");
            List<ProductProperties> _list = new List<ProductProperties>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new ProductProperties
                {
                    productID = Convert.ToInt32(dr["Product_ID"]),
                    productName = dr["Product_Name"].ToString(),
                    categoryID = Convert.ToInt32(dr["FK_Category_ID"]),
                    categoryName = dr["Category_Name"].ToString(),
                    subCategory1ID = Convert.ToInt32(dr["FK_First_Category_ID"]),
                    FirstcategoryName = dr["First_Category_Name"].ToString(),
                    subCategory2ID = Convert.ToInt32(dr["FK_Second_Category_ID"]),
                    SecondcategoryName = dr["Second_Category_Name"].ToString(),
                    subCategory3ID = Convert.ToInt32(dr["FK_Third_Category_ID"]),
                    ThirdcategoryName = dr["Third_Category_Name"].ToString(),
                    price = dr["Price"].ToString(),
                    brandID = Convert.ToInt32(dr["FK_Brand_ID"]),
                    BrandName = dr["Brand_Name"].ToString(),
                    ImagePath = dr["ImagePath"].ToString(),
                    quantity = dr["Qty"].ToString(),
                    description = dr["Description"].ToString()
                });
            }

            return _list;
        }

        public List<ProductProperties> SelectShoeProducts()
        {
            DataTable dt = new DataTable();
            dt = DB.getdatatable("SelectShoeProducts");
            List<ProductProperties> _list = new List<ProductProperties>();
            foreach (DataRow dr in dt.Rows)
            {
                _list.Add(new ProductProperties
                {
                    productID = Convert.ToInt32(dr["Product_ID"]),
                    productName = dr["Product_Name"].ToString(),
                    categoryID = Convert.ToInt32(dr["FK_Category_ID"]),
                    categoryName = dr["Category_Name"].ToString(),
                    subCategory1ID = Convert.ToInt32(dr["FK_First_Category_ID"]),
                    FirstcategoryName = dr["First_Category_Name"].ToString(),
                    subCategory2ID = Convert.ToInt32(dr["FK_Second_Category_ID"]),
                    SecondcategoryName = dr["Second_Category_Name"].ToString(),
                    subCategory3ID = Convert.ToInt32(dr["FK_Third_Category_ID"]),
                    ThirdcategoryName = dr["Third_Category_Name"].ToString(),
                    price = dr["Price"].ToString(),
                    brandID = Convert.ToInt32(dr["FK_Brand_ID"]),
                    BrandName = dr["Brand_Name"].ToString(),
                    ImagePath = dr["ImagePath"].ToString(),
                    quantity = dr["Qty"].ToString(),
                    description = dr["Description"].ToString()
                });
            }

            return _list;
        }

    }
}
