using Microsoft.AspNetCore.Mvc;
using Projeto_Emprestimo.Models;
using Projeto_Emprestimo.Repository.Contract;
using Projeto_Emprestimo.GerenciaArquivos;

namespace Projeto_Emprestimo.Controllers
{
    public class LivrosController : Controller
    {
 
       private ILivroRepository _livroRepository;

        public LivrosController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }
        public IActionResult index()
        {
            return View();
        }
        public IActionResult index(Livro livro, IFormFile file)
        {
            var Caminho = GerenciaArquivo.CadastrarImagemProduto(file);
            livro.imagemLivro = Caminho;
            _livroRepository.Cadastrar(livro);

            ViewBag.msg = "Cadastro realizado";
            return View();
            
        }

    }
}
