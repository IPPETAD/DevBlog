using DevBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevBlog.Controllers
{
	public class HomeController : DbController
	{
		public HomeController()
			: base()
		{ 
		}

		public HomeController(ApplicationDbContext context)
			: base(context)
		{ 
		}

		public ActionResult Index()
		{
			return View(db.Articles.ToList());
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";
			return View();
		}
	}
}