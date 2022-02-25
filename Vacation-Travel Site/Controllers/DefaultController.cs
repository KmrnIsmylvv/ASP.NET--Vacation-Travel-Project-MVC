using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vacation_Travel_Site.Models.Classes;

namespace Vacation_Travel_Site.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        // GET: Default
        public ActionResult Index()
        {
            var blogs = context.Blogs.Take(10).ToList();
            return View(blogs);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult PartialBlog()
        {

            var blogs = context.Blogs.OrderByDescending(b => b.Id).Take(2).ToList();
            return PartialView(blogs);
        }

        public PartialViewResult PartialTopTenBlog()
        {
            var blogs = context.Blogs.ToList();
            return PartialView(blogs);
        }

        public PartialViewResult PartialBestBlogs()
        {
            var blogs = context.Blogs.Take(3).ToList();
            return PartialView(blogs);
        }

        public PartialViewResult PartialRightBestBlogs()
        {
            var blogs = context.Blogs.Take(3).OrderByDescending(b => b.Id).ToList();
            return PartialView(blogs);
        }

        //public PartialViewResult RightPartialBlog()
        //{
        //    var blogs = context.Blogs.Where(b=>b.Id==1)
        //    return PartialView();
        //}
    }
}