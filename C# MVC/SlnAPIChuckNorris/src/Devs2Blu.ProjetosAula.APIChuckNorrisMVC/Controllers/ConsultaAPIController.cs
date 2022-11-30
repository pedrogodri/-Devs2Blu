using Devs2Blu.ProjetosAula.APIChuckNorrisMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.APIChuckNorrisMVC.Controllers
{
    [Route("consulta")]
    public class ConsultaAPIController : Controller
    {
        private readonly ChuckNorrisAPIService Service = new ChuckNorrisAPIService();
        public async Task<IActionResult> Index()
        {
            var result = await Service.GetPhraseChuck();
            return View(result);
        }

        [Route("phrase")]
        public PartialViewResult ChuckNorris()
        {
            var result = Service.GetPhraseChuck();
            return PartialView();
        }
    }
}
