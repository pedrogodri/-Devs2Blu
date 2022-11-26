using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = new List<User>()
            {
                new User {Id = 1, Name = "Pedro Godri", Login = "pedroG"},
                new User {Id = 2, Name = "Rafael Ronchi", Login = "rafaR"},
                new User {Id = 3, Name = "Vitor Schiphorst", Login = "vitorS"},
                new User {Id = 4, Name = "Barbara Nascimento", Login = "barbaraN"},
                new User {Id = 5, Name = "Nicolas Maba", Login = "nicolasM"},
                new User {Id = 6, Name = "Nany Godri", Login = "nanyG"},
                new User {Id = 7, Name = "Gian Godri", Login = "gianG" }
            };
            return View(users);
        }

        [Route("indicadores")]    
        [Route("numbers")]    
        public IActionResult Indicadores()
        {
            return View();
        }

        [Route("cards")]
        public PartialViewResult CardsResultados()
        {
            //var result = Service.GetLista();
            return PartialView();
        }
    }
}
