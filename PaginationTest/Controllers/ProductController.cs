using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PaginationTest.DAL;
using System.Web.Mvc;

namespace PaginationTest.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductList
        public ActionResult ProductList()
        {

            var products = MockProductDao.GetAllProducts();

            return View(products);
        }
    }
}