using Microsoft.AspNetCore.Mvc;
using PizzariAtv.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariAtv.Controllers
{
    public class SaboresController : Controller
    {
        private PizzariaDbContext _context;

        public SaboresController(PizzariaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Sabores);
        }
        public IActionResult Detalhes(int id)
        {
            return View(_context.Sabores);

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
