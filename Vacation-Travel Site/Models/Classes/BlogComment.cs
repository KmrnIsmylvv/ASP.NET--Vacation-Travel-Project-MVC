using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vacation_Travel_Site.Models.Classes
{
    public class BlogComment
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Comments> Comments { get; set; }
    }
}