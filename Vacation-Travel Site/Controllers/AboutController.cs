using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vacation_Travel_Site.Models.Classes;

namespace Vacation_Travel_Site.Controllers
{
    public class AboutController : Controller
    {
        Context context = new Context();
        // GET: About
        public ActionResult Index()
        {
            var variables = context.Abouts.ToList();
            return View(variables);
        }
    }
}