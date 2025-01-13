using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HariharanBlog.Models;

namespace HariharanBlog.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext db = new BlogContext();

        public ActionResult Index()
        {
            var posts = db.BlogPosts.ToList();
            return View();
        }

        public ActionResult Details(int id)
        {
            var post = db.BlogPosts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

	}
}