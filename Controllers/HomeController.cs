using System.Web.Mvc;

namespace News.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult Criatividade()
		{
			return View();
		}
	}
}