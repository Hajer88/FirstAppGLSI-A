using FirstAppGLSI_A.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAppGLSI_A.Controllers
{
    public class ProduitController : Controller
    {
        //Ajouter des enregistrements d'une manière statique à Produit
        public IActionResult Index()
        {
            //Syntaxe d'initialisation
            List<Produit> produits = new List<Produit>()
            {
                new Produit(){Name="Produit 1"},
                new Produit(){Name="Produit 2"},
            };
            return View(produits);
        }
        public IActionResult Edit(int id)
        {
            return Content("Id   " + id);
        }
        public IActionResult ProduitClient()
        {
            Produit p = new Produit() { Name = "Produit 1" };
            ProduitClientVM produitClientVM = new ProduitClientVM()
            {
                clients = Listclient().ToList(),
                produit = p,
            };
            return View(produitClientVM);
        }
        public IActionResult DetailsClient(int id)
        {
            var client = Listclient().SingleOrDefault(c => c.Id == id);
            return View(client);
        }
        private List<Client> Listclient()
        {
            return new List<Client>()
            {
                new Client(){Id=1, Name="Client 1"},
                new Client(){Id=2, Name="Client 2"},
            };
        }
    }
}
