using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vacation_Travel_Site.Models.Classes;

namespace Vacation_Travel_Site.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        BlogComment blogComment = new BlogComment();
        // GET: Blog
        public ActionResult Index()
        {
            //var blogs = context.Blogs.ToList();

            blogComment.Blogs = context.Blogs.ToList();

            var lastBlogs = blogComment.Blogs.OrderByDescending(b=>b.Id).Take(3).ToList();
            ViewBag.lastBlogs = lastBlogs;

            return View(blogComment);
        }

        
        public ActionResult Detail(int? id)
        {
            blogComment.Blogs = context.Blogs.Where(b => b.Id == id).ToList();
            blogComment.Comments = context.Comments.Where(c => c.BlogId == id); 
            //var blog = context.Blogs.Where(b => b.Id == id).ToList();
            return View(blogComment);
        }

        [HttpGet]
        public ActionResult CreateComment(int id)
        {
            ViewBag.blogId = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult CreateComment(Comments comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();

            return PartialView();
        }
    }
}