
using Microsoft.AspNetCore.Mvc;
using PizzariAtv.Data;
using PizzariAtv.Models.ViewModels.Responsive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariAtv.Controllers
{
    public class PizzasController : Controller
    {
        private PizzariaDbContext _context;

        public PizzasController(PizzariaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Pizzas);
        }
        public IActionResult Detalhes(int id)
        {
            var result = _context.Pizzas.Where(prod => prod.Id == id)
                .Select(prod => new GetPizzasDTO()
                {
                    Nome = prod.Nome,
                    Descricao = prod.Descricao,
                    ImagemURL = prod.ImagemURL,
                    Preco = prod.Preco
                }).FirstOrDefault();

            return View(result);

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
