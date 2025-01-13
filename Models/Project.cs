using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HariharanBlog.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tools { get; set; }
        public string Link { get; set; } // Optional: Add project demo links
    }
}