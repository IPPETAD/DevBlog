using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevBlog.Controllers
{
    public class ArticleController : Controller
    {
        [Route("search")]
        public ActionResult Index()
        {
            return View();
        }
	}
}