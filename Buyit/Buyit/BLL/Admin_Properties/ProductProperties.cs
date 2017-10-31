using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin_Properties
{
    public class ProductProperties
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string filename { get; set; }
        public int categoryID { get; set; }
        public int subCategory1ID { get; set; }
        public int subCategory2ID { get; set; }
        public int subCategory3ID { get; set; }
        public int brandID { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }

        public string categoryName { get; set; }
        public string FirstcategoryName { get; set; }
        public string SecondcategoryName { get; set; }
        public string ThirdcategoryName { get; set; }
        public string BrandName { get; set; }
        public string ImagePath { get; set; }

        
        public string serProduct { get; set; }
        public string serCategory { get; set; }
        public string serSubCat1 { get; set; }
        public string serSubCat2 { get; set; }
        public string serSubCat3 { get; set; }
        public string serPrice { get; set; }
        public string serBrand { get; set; }
        public string serQty { get; set; }
        public string serDescription { get; set; }
    }
}
