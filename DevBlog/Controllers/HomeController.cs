using DevBlog.Models;
using System.Web.Mvc;

namespace DevBlog.Controllers
{
    public class HomeController : Controller
    {
        private ArticleDBContext db = new ArticleDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}