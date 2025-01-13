using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HariharanBlog.Models;

namespace HariharanBlog.Controllers
{
    public class ProjectsController : Controller
    {
        private BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            var projects = db.Projects.ToList();
            return View(projects);

        }
	}
}