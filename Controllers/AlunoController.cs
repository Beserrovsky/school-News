using System.Web.Mvc;

namespace News.Controllers
{
    public class AlunoController : Controller
    {
        public PartialViewResult Aluno()
        {
            return PartialView("~/Areas/Aluno/Aluno.cshtml");
        }
    }
}
