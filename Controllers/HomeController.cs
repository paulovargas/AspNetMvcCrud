using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using crud.Models;
using Microsoft.EntityFrameworkCore;

namespace crud.Controllers;

public class HomeController : Controller
{
   private readonly Contexto _contexto;

       public HomeController(Contexto contexto)
       {
            _contexto = contexto;                
       }

       public async Task<IActionResult> Index()
       {
            //return View();        
            return View(await _contexto.Produtos.ToListAsync());
       }

       [HttpGet]
       public IActionResult NovoProduto()
       {
            return View();        
       }

       [HttpPost]
       public async Task<IActionResult> NovoProduto(Produto produto)
       {
            await _contexto.Produtos.AddAsync(produto);
            await _contexto.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
       }

        [HttpGet]
        public async Task<IActionResult> AtualizarProduto(int Id)
        {
            Produto produto = await _contexto.Produtos.FindAsync(Id);

            return View(produto);
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarProduto(Produto produto)
        {
            _contexto.Produtos.Update(produto);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirProduto(int Id)
        {
            Produto produto = await _contexto.Produtos.FindAsync(Id);
            _contexto.Produtos.Remove(produto!);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

}
