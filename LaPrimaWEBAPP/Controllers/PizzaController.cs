using Microsoft.AspNetCore.Mvc;
using LaPrimaWEBAPP.Models;
using LaPrimaWEBAPP.Utils;

namespace LaPrimaWEBAPP.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizze> pizze = PizzaData.GetPizze();
            return View("HomePage", pizze);
        }

        [HttpGet]
        public IActionResult Details(string nome)
        {

            Pizze pizzeFound = null;
            foreach (Pizze pizza in PizzaData.GetPizze())
            {
                if (pizze.nome == nome)
                {
                    pizzeFound = pizza;
                    break;
                }
            }

            if (pizzeFound != null)
            {
                return View("Details", pizzeFound);
            }
            else
            {
                return NotFound("La pizza con nome " + nome + " non è stato trovato");
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("FormPostPizza");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizze nuovaPizza)
        {
            if (!ModelState.IsValid)
            {
                return View("ErrorePost", nuovaPizza);
            }
        
        Pizze nuovaPizzaConNome = new Pizze(PizzaData.GetPosts().Count, nuovaPizza.Nome, nuovaPizza.Descrizione, nuovaPizza.Prezzo)
            
                PizzaData.GetPosts().Add(nuovaPizzaConNome);
            return RedirectToAction("HomePage");
        }

    }
}

 