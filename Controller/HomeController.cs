using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"e:\lighthouse.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"e:\lighthouse.jpg", "image/jpg",
           "default.jpg");
        }

        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1>This is a demo of  ContentResult </ h1 > ");
            }
            else if (id.ToLower() == "plain")
            {
                return Content("<h1>This is a demo of ContentResult </ h1 > ", "text / plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1>This is a demo of ContentResult </ h1 > ", "text / html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1>This is a demo of ContentResult </ h1 > ", "text / xml");
            }
            return Content("Invalid content type");
        }
        public ActionResult Google()
        {
            return Redirect("http://www.google.com");
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }





    }



}