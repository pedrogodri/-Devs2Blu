using Devs2Blu.ProjetosAula.Exercicio2MVC.Service;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.Exercicio2MVC.Controllers
{
    [Route("maps")]
    public class MapsAPIController : Controller
    {
        private readonly ILogger<MapsAPIController> _logger;
        private readonly ServiceAPI service;

        public MapsAPIController(ILogger<MapsAPIController> logger)
        {
            _logger = logger;
            service = new ServiceAPI();
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("loadmaps")]
        public async Task<PartialViewResult> LoadListMaps()
        {
            _logger.LogInformation("Carregando a lista de Mapas");
            var result = await service.GetListMaps();
            var listMaps = result.ToList();
            return PartialView(listMaps);
        }

        [Route("search/{nameMap}")]
        public async Task<PartialViewResult> SearchMaps(string nameMap)
        {
            var map = await service.GetMapsByName(nameMap);
            return PartialView(map);
        }
    }
}
