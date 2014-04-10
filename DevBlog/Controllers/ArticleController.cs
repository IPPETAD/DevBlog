using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevBlog.Models;
using Microsoft.AspNet.Identity;

namespace DevBlog.Controllers
{
	[Authorize]
    public class ArticleController : DbController
    {
		public ArticleController()
			: base()
		{ 
		}

		public ArticleController(ApplicationDbContext context)
			: base(context)
		{ 
		}

		[AllowAnonymous]
        [Route("Search")]
        public ActionResult Index()
        {
            return View();
        }

		[AllowAnonymous]
		//[Authorize(Roles=BlogRole.AUTHOR)]
		public ActionResult New()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		//[Authorize(Roles=BlogRole.AUTHOR)]
		[AllowAnonymous]
		public ActionResult New(Article article)
		{
			if (ModelState.IsValid)
			{
				article.DatePublished = DateTime.UtcNow;
				article.Author = db.Users.Find(User.Identity.GetUserId());
				db.Articles.Add(article);
				db.SaveChanges();
				return RedirectToAction("Index", "Home");
			}

			return View(article);
		}

	}
}