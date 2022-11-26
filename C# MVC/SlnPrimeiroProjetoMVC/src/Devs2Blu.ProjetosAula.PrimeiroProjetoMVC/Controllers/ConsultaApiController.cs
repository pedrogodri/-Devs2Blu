using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("consulta")]
    public class ConsultaApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
  
        public IActionResult Indicadores()
        {
            return View();
        }

        [Route("pokemons")]
        public PartialViewResult Pokemons()
        {
            //var result = Service.GetLista();
            return PartialView();
        }
    }
}
