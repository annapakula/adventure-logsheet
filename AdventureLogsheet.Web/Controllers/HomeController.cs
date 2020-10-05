using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdventureLogsheet.Web.Models;

namespace AdventureLogsheet.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Konstruktor kontrolera; przyjmuje element który jest związany z dependency injection (wstrzykiwaniem zależności), jest to związane z wstrzykiwaniem loggera
        //czyli mechanizmu do logowania informacji na temat błędów, interakcji z użytkownikiem itd.
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Akcje kontrolera odpowiedzialne za wyświetlanie różnych widoków
        public IActionResult Index()
        {
            return View();
        }

        [Route("Characters")]
        public IActionResult ViewListOfCharacters()
        {
            List<Character> characters = new List<Character>();
            characters.Add(new Character()
            {
                Id = 1,
                Name = "Nix",
                Race = "Gnome",
                //Classes = "Fighter",
                //Level = 5,
                //DCINumber = "",
            });
            characters.Add(new Character()
            {
                Id = 2,
                Name = "Sadha",
                Race = "Dragonborn",
                //Classes = "Barbarian",
                //Level = 2,
                //DCINumber = "",
            });
            characters.Add(new Character()
            {
                Id = 3,
                Name = "Anka Tivish",
                Race = "Mountain Dwarf",
                CharacterClasses = new List<CharacterClass>()
                {
                    new CharacterClass() { CharClass = "Rogue", Level = 5 }, 
                    new CharacterClass() { CharClass = "Warlock", Level = 1 }
                },
                //Classes = "Rogue",
                //Level = 5,
               // DCINumber = "",
            });
            return View(characters);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
