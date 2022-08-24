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
            return View(_context.Tamanhos.Find(id));

        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(PostTamanhoDTO tamanhoDTO)
        {
            if (!ModelState.IsValid) { return View(); }

            Tamanho tamanho = new Tamanho
            (
                tamanhoDTO.Nome,
                tamanhoDTO.Pedacos,
                tamanhoDTO.Descricao
            );
            _context.Tamanhos.Add(tamanho);
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
        public IActionResult Atualizar(int id, PostTamanhoDTO tamanhoDTO)
        {
            var result = _context.Tamanhos.FirstOrDefault(x => x.Id == id);
            if (!ModelState.IsValid) return View(result);
            result.AtualizarDados(tamanhoDTO.Nome,tamanhoDTO.Pedacos,tamanhoDTO.Descricao);
            _context.Update(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Deletar(int id)
        {
            var remove = _context.Tamanhos.FirstOrDefault(x => x.Id == id);
            if (remove == null) return View("NotFound");
            return RedirectToAction(nameof(Index));
        }
        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmarDeletar(int id)
        {
            var remove = _context.Tamanhos.FirstOrDefault(x => x.Id == id);
            if (remove == null) return View("NotFound");
            _context.Remove(remove);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
