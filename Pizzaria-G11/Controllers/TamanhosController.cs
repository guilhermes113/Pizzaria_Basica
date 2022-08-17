using Microsoft.AspNetCore.Mvc;
using PizzariAtv.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariAtv.Controllers
{
    public class TamanhosController : Controller
    {
        private PizzariaDbContext _context;

        public TamanhosController(PizzariaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.Tamanhos;
            return View(result);
        }
        public IActionResult Detalhes(int id)
        {
            return View(_context.Tamanhos);

        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Atualizar()
        {
            return View();
        }
        public IActionResult Deletar()
        {
            return View();
        }
    }
}
