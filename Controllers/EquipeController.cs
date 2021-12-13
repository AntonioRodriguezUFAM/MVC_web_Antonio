using E_JOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {
        // 
        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            // View = Responsavel pelo exibicao do Frontend.
            // bag = 
            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }
        public IActionResult Cadastar( )
        {

        }
    }
}
