using PagedList;
using PaginationTest.DAL;
using PaginationTest.Models;
using System.Web.Mvc;

namespace PaginationTest.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductList
        public ActionResult ProductList(int page = 1, int pageSize = 10)
        {
            var products = MockProductDao.GetAllProducts();

            PagedList<Product> model = new PagedList<Product>(products, page, pageSize);

            return View(model);
        }
    }
}