using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductDataAccessLayer_Lib;

namespace ProductMVC_WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            ProductDAL dal = new ProductDAL();
            var IDs = dal.GetAllCategoryID().ToList();
            ViewData.Add("categoryIds", IDs);
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product prod)
        {
            ProductDAL dal = new ProductDAL();
            var IDs = dal.GetAllCategoryID().ToList();
            ViewData.Add("categoryIds", IDs);
            if (ModelState.IsValid)
            {
                dal.AddProduct(prod);
                ViewData.Add("Message", "Product record added");
            }
            return View();
        }
        [HttpGet]
        public ActionResult GetAllProducts()
        {
            ProductDAL dal = new ProductDAL();
            List<Product> products = dal.GetAllProducts();
            return View(products);
        }
        [HttpGet]
        public ActionResult Details(int id , string CID)
        {
            ProductDAL dal = new ProductDAL();
            var record = dal.GetProductDetails(id);
            var CategoryName = dal.GetCategoryName(CID);
            ViewData.Add("categoryname", CategoryName);
            return View(record);
        }
    }
}