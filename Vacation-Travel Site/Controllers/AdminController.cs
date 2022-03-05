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
        [Authorize]
        public ActionResult Index()
        {
            var blogs = context.Blogs.ToList();

            return View(blogs);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var blog = context.Blogs.Find(id);

            return View("UpdateBlog", blog);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog currentBlog)
        {
            var blog = context.Blogs.Find(currentBlog.Id);
            blog.Title = currentBlog.Title;
            blog.Description = currentBlog.Description;
            blog.BlogImage = currentBlog.BlogImage;
            blog.Date = currentBlog.Date;

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult CommentList()
        {
            var comments = context.Comments.ToList();
            return View(comments);
        }

        public ActionResult DeleteComment(int id)
        {
            var comment = context.Comments.Find(id);
            context.Comments.Remove(comment);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}