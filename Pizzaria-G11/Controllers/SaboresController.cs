using Microsoft.AspNetCore.Mvc;
using PizzariaAtv.Models.ViewModels.Request;
using PizzariAtv.Data;
using PizzariAtv.Models;
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
            return View(_context.Sabores.Find(id));

        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(PostSaborDTO saborDTO)
        {
            if (!ModelState.IsValid) { return View(); }

            Sabor sabor = new Sabor
            (
                saborDTO.Nome,
                saborDTO.Descricao,
                saborDTO.ImagemURL
            );
            _context.Sabores.Add(sabor);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Atualizar(int id)
        {
            var result = _context.Sabores.FirstOrDefault(x => x.Id == id);
            if (result == null) return View("NotFound");
            var resp = new PostSaborDTO()
            {
                Nome = result.Nome,
                Descricao = result.Descricao,
                ImagemURL = result.ImagemURL
                
            };
            return View(resp);
        }
        [HttpPost]
        public IActionResult Atualizar(int id, PostSaborDTO saborDTO)
        {
            var result = _context.Sabores.FirstOrDefault(x => x.Id == id);
            if (!ModelState.IsValid) return View(result);
            result.AtualizarDados(saborDTO.Nome, saborDTO.Descricao,saborDTO.ImagemURL);
            _context.Update(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Deletar(int id)
        {
            var remove = _context.Sabores.FirstOrDefault(x => x.Id == id);
            if (remove == null) return View("NotFound");
            return RedirectToAction(nameof(Index));
        }
        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmarDeletar(int id)
        {
            var remove = _context.Sabores.FirstOrDefault(x => x.Id == id);
            if (remove == null) return View("NotFound");
            _context.Remove(remove);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
