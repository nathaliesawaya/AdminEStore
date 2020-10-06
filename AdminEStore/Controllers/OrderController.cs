using AdminEStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminEStore.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewOrders()
        {

            List<OrderModel> AllOrdersModel = new List<OrderModel>();

            //List<ProductModel> AllProducts = new List<ProductModel>();   
            
            ListProdCat AllCategorys = new ListProdCat();

            OrderModel ordersModel = new OrderModel();

            ProductModel FirstProduct = new ProductModel
            {
             
                Product_ID = 1,
                Product_Name = "Laptop1",
                Product_Price = 300,
                Product_Category ="2",
                Product_CatName = AllCategorys.CategoryLookup[1]

            };


            ProductModel SecondProduct = new ProductModel
            {

                Product_ID = 2,
                Product_Name = "Food1",
                Product_Price = 200,
                Product_Category = "1",
                Product_CatName = AllCategorys.CategoryLookup[0]
            };



            ProductModel ThirdProduct = new ProductModel
            {

                Product_ID = 3,
                Product_Name = "Food1",
                Product_Price = 400,
                Product_Category = "1",
                Product_CatName = AllCategorys.CategoryLookup[0]
            };

            ProductModel ForthProduct = new ProductModel
            {

                Product_ID = 4,
                Product_Name = "Food2",
                Product_Price = 150,
                Product_Category = "1",
                Product_CatName = AllCategorys.CategoryLookup[0]
            };


            ProductModel FifthProduct = new ProductModel
            {

                Product_ID = 5,
                Product_Name = "Game1",
                Product_Price = 250,
                Product_Category = "3",
                Product_CatName = AllCategorys.CategoryLookup[2]
            };


            OrderedProducts firstOrderPorduct = new OrderedProducts
            {
                Order_Id = 2000001,
                Product_Quantity = 3,
                Ordproduct = FirstProduct

            };

            OrderedProducts SecondOrderProduct = new OrderedProducts
            {
                Order_Id = 2000001,
                Product_Quantity = 4,
                Ordproduct = SecondProduct
            };

            OrderedProducts ThirdOrderProduct = new OrderedProducts
            {
                Order_Id = 3000001,
                Product_Quantity = 5,
                Ordproduct = ThirdProduct
            };

            OrderedProducts ForthOrderProduct = new OrderedProducts
            {
                Order_Id = 3000001,             
                Product_Quantity = 5,
                Ordproduct = ForthProduct
            };



            ordersModel.ListOrderedProducts.Add(firstOrderPorduct);
            ordersModel.ListOrderedProducts.Add(SecondOrderProduct);
            ordersModel.ListOrderedProducts.Add(ThirdOrderProduct);
            ordersModel.ListOrderedProducts.Add(ThirdOrderProduct);

            AllOrdersModel.Add(ordersModel);

         

            return View(AllOrdersModel);
        }

    }
}