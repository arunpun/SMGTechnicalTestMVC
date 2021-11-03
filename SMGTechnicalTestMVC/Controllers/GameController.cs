using Microsoft.AspNetCore.Mvc;
using SMGTechnicalTestMVC.Data;
using SMGTechnicalTestMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMGTechnicalTestMVC.Controllers
{
    public class GameController : Controller
    {
        //Use dependency injection to write data to the database using ApplicationDbContext
        private readonly ApplicationDbContext _db;

        //Constructor to get database context
        public GameController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //Get all the items from the database
            IEnumerable<Game> games = _db.Games;

            return View(games);
        }
    }
}
