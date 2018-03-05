using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebProjeto.DataProvider.Context;
using WebProjeto.DataProvider.Models;
using WebProjeto.DataProvider.Service;

namespace WebProjeto.Controllers
{
    public class LivroController : Controller
    {
        private WebProjetoContext db = new WebProjetoContext();

        private LivroService livroService;

        public LivroController()
        {
            livroService = new LivroService();
        }

        // GET: ProdutoModels
        public ActionResult Livro()
        {
            return View(livroService.ListaLivro());
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult PersisteLivro([Bind(Include = "Id,Nome,Autor,Editora")] LivroModel livroModel)
        {
            var retorno = livroService.Salvar(livroModel);

            return Json(new { Resultado = retorno });
        }

        public ActionResult RemoverLivro([Bind(Include = "Id,Nome,Autor,Editora")] LivroModel livroModel)
        {
            var retorno = livroService.Remover(livroModel);

            return Json(retorno);
        }

        public ActionResult RecuperaLivro([Bind(Include = "Id,Nome,Autor,Editora")] LivroModel livroModel)
        {
            return Json(livroService.ListarPorId(livroModel));
        }

    }
}
