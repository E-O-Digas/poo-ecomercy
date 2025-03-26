using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers;

public class ProdutoController : Controller {
    public ActionResult Index() {
        List<Produto> produtos = new List<Produto>();

        produtos.Add(new Produto {ProdutoId = 1, Nome = "A"});
        produtos.Add(new Produto {ProdutoId = 2, Nome = "B"});
        produtos.Add(new Produto {ProdutoId = 3, Nome = "C"});

        return View(produtos);

    }

}