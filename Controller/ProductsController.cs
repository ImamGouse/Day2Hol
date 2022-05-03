using Microsoft.AspNetCore.Mvc;

namespace WebApplication4
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            Models.Product p = new Models.Product();

            //pass a list of products to the view
            return View(p.GetProducts());

        }

    }



}