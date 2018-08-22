//2 Add Controller
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            //3b Must have name of Method in Controller
            Entry entry = new Entry()
            {
                Name = "First",
                Build = "Best"
            };
            entry.Name = "First";
            //6 Pass Model to View from Controller
            return View(entry);
        }
    }
}