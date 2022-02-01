using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vacation_Travel_Site.Models.Classes
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string Desctiption { get; set; }
    }
}