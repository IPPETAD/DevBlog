using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevBlog.Models;

namespace DevBlog.Controllers
{
    public class DbController : Controller
    {
		protected ApplicationDbContext db;

        public DbController()
			: this(new ApplicationDbContext())
		{

		}

		public DbController(ApplicationDbContext context)
		{
			db = context;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}

			base.Dispose(disposing);
		}

	}
}