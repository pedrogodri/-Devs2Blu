using Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQLServerAppCompras.Web.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaService _service;

        public CategoriasController(ICategoriaService service)
        {
            _service = service;
        }

        // GET: CategoriasController
        public async Task<ActionResult> Index()
        {
            var listCategorias = await _service.GetAllCategorias();
            return View(listCategorias);
        }

        // GET: CategoriasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Id,Nome")] Categoria categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _service.Save(categoria);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
            }
                return View(categoria);
        }

        // GET: CategoriasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
