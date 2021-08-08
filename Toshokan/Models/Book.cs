using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Toshokan.Models
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public string Publisher { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
    }
}