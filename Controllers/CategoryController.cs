using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;
using WebMVC.Dal;

namespace WebMVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult List()
        {
            return View();
        }

        public ActionResult insert()
        {
            return View();

        }

        public ActionResult edit()
        {
            return View();

        }

        public ActionResult delete()
        {
            return View();

        }
    }
}