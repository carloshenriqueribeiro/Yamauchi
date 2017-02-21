using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YamauchiEstoque.DAO;
using YamauchiEstoque.Filtros;
using YamauchiEstoque.Models;
namespace YamauchiEstoque.Controllers
{
    [AutorizacaoFilter]
    public class CategoriaController : Controller
    {
        //
        // GET: /Produto/

        public ActionResult Index()
        {
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias = dao.Lista();
            ViewBag.Categorias = categorias;
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(CategoriaDoProduto categoria)
        {
            CategoriasDAO dao = new CategoriasDAO();
            dao.Adiciona(categoria);
            return RedirectToAction("Index");
        }
    }
}