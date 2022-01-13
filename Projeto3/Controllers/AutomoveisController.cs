using Microsoft.AspNetCore.Mvc;
using Projeto3.Models;
using Projeto3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto3.Controllers
{
    public class AutomoveisController : Controller

    {
        private readonly AutomoveisService _automoveisService;
        private readonly LocadoraService _locadoraService;

        public AutomoveisController(AutomoveisService automoveisService, LocadoraService locadoraService)
        {
            _automoveisService = automoveisService;
            _locadoraService = locadoraService;
        }
        public IActionResult Index()
        {
            var list = _automoveisService.FindAll();

            return View(list);
        }

        public IActionResult Create()
        {
            var locadora = _locadoraService.FindAll();
            var viewModel = new AutomoveisFormViewModel { Locadoras = locadora };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Automoveis automoveis)
        {
            _automoveisService.Insert(automoveis);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _automoveisService.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}
