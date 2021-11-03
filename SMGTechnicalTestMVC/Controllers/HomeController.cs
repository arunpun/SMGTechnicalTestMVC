using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SMGTechnicalTestMVC.Data;
using SMGTechnicalTestMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SMGTechnicalTestMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //Use dependency injection to get data from the database using ApplicationDbContext
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult App()
        {
            Game game = new Game();
            game.ComputerChoice = "";
            game.PlayerChoice = "";
            game.GameResult = "";

            return View(game);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult App(Game game)
        {
            //Call method to pass playerChoice to a game helper class and determine the result
            var playerChoice = game.PlayerChoice;
            var gameHelper = new GameHelper();
            var newGame = gameHelper.GetResults(game);

            if (ModelState.IsValid && game.GameResult != null)
            {
                _db.Games.Add(newGame);
                _db.SaveChanges();
            }

            return View(newGame);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
