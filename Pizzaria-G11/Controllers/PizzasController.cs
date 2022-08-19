
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzariaAtv.Models.ViewModels.Request;
using PizzariAtv.Data;
using PizzariAtv.Models;
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
            var result = _context.Pizzas
                .Include(t => t.Tamanho)
                .Include(ps => ps.PizzasSabores).ThenInclude(c => c.Sabor)
                .FirstOrDefault(p => p.Id == id);
            GetPizzasDTO pizzasDTO = new GetPizzasDTO()
            {
                Nome = result.Nome,
                Descricao = result.Descricao,
                ImagemURL = result.ImagemURL,
                Preco = result.Preco,
                Tamanho = result.Tamanho.Nome,
                Sabores = result.PizzasSabores.Select(x => x.Sabor.Nome).ToList()
            };
            return View(pizzasDTO);

        }
        public IActionResult Criar()
        {
            DadosDropDow();
            return View();
        }
        public void DadosDropDow()
        {
            var resp = new PostPizzaDropDown()
            {
                Sabores = _context.Sabores.OrderBy(x => x.Nome).ToList(),
                Tamanhos = _context.Tamanhos.OrderBy(x => x.Nome).ToList()
            };

            ViewBag.Sabores = new SelectList(resp.Sabores, "Id", "Nome");
            ViewBag.Tamanhos = new SelectList(resp.Tamanhos, "Id", "Nome");

        }
        [HttpPost]IActionResult Criar([Bind("Nome,Descricao,ImagemURL")]PostPizzaDTO pizzaDTO)
        {
            if (!ModelState.IsValid)
            {
                DadosDropDow();
                return View();
            }
            Pizza pizza = new Pizza
                (
                    pizzaDTO.Nome,
                    pizzaDTO.Descricao,
                    pizzaDTO.Preco,
                    pizzaDTO.ImagemURL,
                    pizzaDTO.TamanhoId
                );
            _context.Add(pizza);
            _context.SaveChanges();
            foreach (var sabor in pizzaDTO.SaboresId)
            {
                int? saborId = _context.Sabores.Where(c => c.Id == sabor).FirstOrDefault().Id;

                if (saborId != null)
                {
                    var novoSabor = new PizzasSabores(pizza.Id, saborId.Value);
                    _context.PizzasSabores.Add(novoSabor);
                    _context.SaveChanges();
                }
            }
            
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Atualizar(int id)
        {
            var result = _context.Pizzas.Include(x => x.PizzasSabores).ThenInclude(x => x.Sabor)
                                        .FirstOrDefault(x => x.Id == id);
            if (result == null) return View("NotFound");
            var resp = new PostPizzaDTO()
            {
                Nome = result.Nome,
                Descricao = result.Descricao,
                Preco = result.Preco,
                ImagemURL = result.ImagemURL,
                TamanhoId = result.TamanhoId,
                SaboresId = result.PizzasSabores.Select(x => x.SaborId).ToList()
            };
            DadosDropDow();
            return View(resp);
        }
        [HttpPost]
        public IActionResult Atualizar(int id, PostPizzaDTO pizzaDTO)
        {
            var result = _context.Pizzas.FirstOrDefault(x => x.Id == id);
            if (!ModelState.IsValid) return View(result);
            result.AtualizarDados(pizzaDTO.Nome, pizzaDTO.Descricao, pizzaDTO.Preco, pizzaDTO.ImagemURL);
            _context.Update(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Deletar(int id)  
        {
            var remove = _context.Pizzas.FirstOrDefault(x => x.Id == id);
            if (remove == null) return View("NotFound");
            return RedirectToAction(nameof(Index));
        }
        [HttpPost,ActionName("Deletar")]
        public IActionResult ConfirmarDeletar(int id)
        {
            var remove = _context.Pizzas.FirstOrDefault(x => x.Id == id);
            if (remove == null) return View("NotFound");
            _context.Remove(remove);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
