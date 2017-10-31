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
    public partial class Index1 : System.Web.UI.Page
    {
        string html = "";
        string html2 = "";
        UserInterface UI = new UserInterface();
        

        protected void Page_Load(object sender, EventArgs e)
        {

            MensCategory();
            WomensCategory();
            MensProducts();
            WomenProducts();
            BagProducts();
            ShoeProducts();
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

        public void MensProducts() 
        {
            html = "";

            List<ProductProperties> _list = UI.SelectMensProducts();
            for (int i = 0; i < _list.Count; i++)
            {
                html += "<div class='col-md-3 product-men'>";
                html += "<div class='men-pro-item simpleCart_shelfItem'>";
                html += "<div id='MensProductsImage' runat='server' class='men-thumb-item'>";
                html += "<img src='" + _list[i].ImagePath + "' alt='' class='pro-image-front'>";
                html += "<img src='" + _list[i].ImagePath + "' alt='' class='pro-image-back'>";
                html += "<div class='men-cart-pro'>";
                html += "<div class='inner-men-cart-pro'>";
                html += "<a href='single.aspx' class='link-product-add-cart'>Quick View</a>";
                html += "</div>";
                html += "</div>";
                html += "<span class='product-new-top'>New</span>";
                html += "</div>";
                html += "<div class='item-info-product '>";
                html += "<h4><a href='single.aspx'>" + _list[i].productName + "</a></h4>";
                html += "<div class='info-product-price'>";
                html += "<span class='item_price'>" + _list[i].price + "</span>";
                html += "<del></del>";
                html += "</div>";
                html += "<div class='snipcart-details top_brand_home_details item_add single-item hvr-outline-out button2'>";
                html += "<form action='#' method='post'>";
                html += "<fieldset>";
                html += "<input type='hidden' name='cmd' value='_cart' />";
                html += "<input type='hidden' name='add' value='1' />";
                html += "<input type='hidden' name='business' value=' ' />";
                html += "<input type='hidden' name='item_name' value='" + _list[i].productName + "' />";
                html += "<input type='hidden' name='amount' value='" + _list[i].price + "' />";
                html += "<input type='hidden' name='discount_amount' value='1.00' />";
                html += "<input type='hidden' name='currency_code' value='INR' />";
                html += "<input type='hidden' name='return' value=' ' />";
                html += "<input type='hidden' name='cancel_return' value=' ' />";
                html += "<input type='submit' name='submit' value='Add to cart' class='button' />";
                html += "</fieldset>";
                html += "</form>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";

            }
            MenProduct_Display.InnerHtml = html;
        }

        public void WomenProducts()
        {
            html = "";

            List<ProductProperties> _list = UI.SelectWomensProducts();
            for (int i = 0; i < _list.Count; i++)
            {
                html += "<div class='col-md-3 product-men'>";
                html += "<div class='men-pro-item simpleCart_shelfItem'>";
                html += "<div class='men-thumb-item'>";
                html += "<img src='" + _list[i].ImagePath + "' alt='' class='pro-image-front'>";
                html += "<img src='" + _list[i].ImagePath + "' alt='' class='pro-image-back'>";
                html += "<div class='men-cart-pro'>";
                html += "<div class='inner-men-cart-pro'>";
                html += "<a href='single.aspx' class='link-product-add-cart'>Quick View</a>";
                html += "</div>";
                html += "</div>";
                html += "<span class='product-new-top'>New</span>";
                html += "</div>";
                html += "<div class='item-info-product '>";
                html += "<h4><a href='single.aspx'>" + _list[i].productName + "</a></h4>";
                html += "<div class='info-product-price'>";
                html += "<span class='item_price'>" + _list[i].price + "</span>";
                html += "<del>$189.71</del>";
                html += "</div>";
                html += "<div class='snipcart-details top_brand_home_details item_add single-item hvr-outline-out button2'>";
                html += "<form action='#' method='post'>";
                html += "<fieldset>";
                html += "<input type='hidden' name='cmd' value='_cart' />";
                html += "<input type='hidden' name='add' value='1' />";
                html += "<input type='hidden' name='business' value=' ' />";
                html += "<input type='hidden' name='item_name' value='" + _list[i].productName + "' />";
                html += "<input type='hidden' name='amount' value='" + _list[i].price + "' />";
                html += "<input type='hidden' name='discount_amount' value='1.00' />";
                html += "<input type='hidden' name='currency_code' value='INR' />";
                html += "<input type='hidden' name='return' value=' ' />";
                html += "<input type='hidden' name='cancel_return' value=' ' />";
                html += "<input type='submit' name='submit' value='Add to cart' class='button' />";
                html += "</fieldset>";
                html += "</form>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";

            }
            WomenProduct_Dispaly.InnerHtml = html;
        }

        public void BagProducts()
        {
            html = "";

            List<ProductProperties> _list = UI.SelectBagProducts();
            for (int i = 0; i < _list.Count; i++)
            {
                html += "<div class='col-md-3 product-men'>";
                html += "<div class='men-pro-item simpleCart_shelfItem'>";
                html += "<div class='men-thumb-item'>";
                html += "<img src='" + _list[i].ImagePath + "' alt='' class='pro-image-front'>";
                html += "<img src='" + _list[i].ImagePath + "' alt='' class='pro-image-back'>";
                html += "<div class='men-cart-pro'>";
                html += "<div class='inner-men-cart-pro'>";
                html += "<a href='single.aspx' class='link-product-add-cart'>Quick View</a>";
                html += "</div>";
                html += "</div>";
                html += "<span class='product-new-top'>New</span>";
                html += "</div>";
                html += "<div class='item-info-product '>";
                html += "<h4><a href='single.aspx'>" + _list[i].productName + "</a></h4>";
                html += "<div class='info-product-price'>";
                html += "<span class='item_price'>" + _list[i].price + "</span>";
                html += "<del>$189.71</del>";
                html += "</div>";
                html += "<div class='snipcart-details top_brand_home_details item_add single-item hvr-outline-out button2'>";
                html += "<form action='#' method='post'>";
                html += "<fieldset>";
                html += "<input type='hidden' name='cmd' value='_cart' />";
                html += "<input type='hidden' name='add' value='1' />";
                html += "<input type='hidden' name='business' value=' ' />";
                html += "<input type='hidden' name='item_name' value='" + _list[i].productName + "' />";
                html += "<input type='hidden' name='amount' value='" + _list[i].price + "' />";
                html += "<input type='hidden' name='discount_amount' value='1.00' />";
                html += "<input type='hidden' name='currency_code' value='INR' />";
                html += "<input type='hidden' name='return' value=' ' />";
                html += "<input type='hidden' name='cancel_return' value=' ' />";
                html += "<input type='submit' name='submit' value='Add to cart' class='button' />";
                html += "</fieldset>";
                html += "</form>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";

            }
            BagProduct_Display.InnerHtml = html;
        }

        public void ShoeProducts()
        {
            html = "";

            List<ProductProperties> _list = UI.SelectShoeProducts();
            for (int i = 0; i < _list.Count; i++)
            {
                html += "<div class='col-md-3 product-men'>";
                html += "<div class='men-pro-item simpleCart_shelfItem'>";
                html += "<div class='men-thumb-item'>";
                html += "<img src='" + _list[i].ImagePath + "' alt='' class='pro-image-front'>";
                html += "<img src='" + _list[i].ImagePath + "' alt='' class='pro-image-back'>";
                html += "<div class='men-cart-pro'>";
                html += "<div class='inner-men-cart-pro'>";
                html += "<a href='single.aspx' class='link-product-add-cart'>Quick View</a>";
                html += "</div>";
                html += "</div>";
                html += "<span class='product-new-top'>New</span>";
                html += "</div>";
                html += "<div class='item-info-product '>";
                html += "<h4><a href='single.aspx'>" + _list[i].productName + "</a></h4>";
                html += "<div class='info-product-price'>";
                html += "<span class='item_price'>" + _list[i].price + "</span>";
                html += "<del>$189.71</del>";
                html += "</div>";
                html += "<div class='snipcart-details top_brand_home_details item_add single-item hvr-outline-out button2'>";
                html += "<form action='#' method='post'>";
                html += "<fieldset>";
                html += "<input type='hidden' name='cmd' value='_cart' />";
                html += "<input type='hidden' name='add' value='1' />";
                html += "<input type='hidden' name='business' value=' ' />";
                html += "<input type='hidden' name='item_name' value='" + _list[i].productName + "' />";
                html += "<input type='hidden' name='amount' value='" + _list[i].price + "' />";
                html += "<input type='hidden' name='discount_amount' value='1.00' />";
                html += "<input type='hidden' name='currency_code' value='INR' />";
                html += "<input type='hidden' name='return' value=' ' />";
                html += "<input type='hidden' name='cancel_return' value=' ' />";
                html += "<input type='submit' name='submit' value='Add to cart' class='button' />";
                html += "</fieldset>";
                html += "</form>";
                html += "</div>";
                html += "</div>";
                html += "</div>";
                html += "</div>";

            }
            ShoeProduct_Display.InnerHtml = html;
        }

        public void Submit_Click(object sender, EventArgs e)
        {
            string x = SignUpName.Value;
        }
    }
}