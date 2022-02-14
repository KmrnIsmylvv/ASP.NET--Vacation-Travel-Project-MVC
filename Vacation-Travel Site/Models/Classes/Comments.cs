using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vacation_Travel_Site.Models.Classes
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}