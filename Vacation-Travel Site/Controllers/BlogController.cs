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
        // GET: Blog
        public ActionResult Index()
        {
            var blogs = context.Blogs.ToList();
            return View(blogs);
        }

        BlogComment blogComment = new BlogComment();
        public ActionResult Detail(int? id)
        {
            blogComment.Blogs = context.Blogs.Where(b => b.Id == id).ToList();
            blogComment.Comments = context.Comments.Where(c => c.BlogId == id); 
            //var blog = context.Blogs.Where(b => b.Id == id).ToList();
            return View(blogComment);
        }
    }
}