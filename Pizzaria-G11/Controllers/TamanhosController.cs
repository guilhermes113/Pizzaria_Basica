using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzariaAtv.Models.ViewModels.Responsive;
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
            return View(_context.Tamanhos);
        }
        public IActionResult Detalhes(int id)
        {
            var result = _context.Tamanhos.FirstOrDefault(p => p.Id == id);
            GetTamanhosDTO tamanhosDTO = new GetTamanhosDTO()
            {
                Nome = result.Nome,
                Pedacos = result.Pedacos
            };
            return View(tamanhosDTO);

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
