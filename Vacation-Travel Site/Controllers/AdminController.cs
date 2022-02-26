using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vacation_Travel_Site.Models.Classes;

namespace Vacation_Travel_Site.Controllers
{
    public class AdminController : Controller
    {
        Context context = new Context();

        // GET: Admin
        public ActionResult Index()
        {
            var blogs = context.Blogs.ToList();

            return View(blogs);
        }
    }
}