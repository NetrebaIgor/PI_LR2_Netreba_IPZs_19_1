using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FootballClub.Models;

namespace FootballClub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            FC[] array = {
                new FC {Name = "IBRAHIMOVIC", Price = 29, Raiting = 88, DEF = 32, DRI =82 , PAC = 65, PAS = 81, PHY = 82, SHO =  88},
                new FC {Name = "LLORIS", Price =23 , Raiting = 80, DEF = 64, DRI = 91, PAC = 89, PAS = 68, PHY =84 , SHO =  82},
                new FC {Name = "GBAMIN", Price = 12, Raiting = 79, DEF = 74, DRI = 74, PAC = 80, PAS = 73, PHY = 83, SHO =  57},
                new FC {Name = "SARR", Price = 21, Raiting = 78, DEF = 22, DRI =80 , PAC = 94, PAS = 68, PHY = 64, SHO = 77 },
                new FC {Name = "KEPA", Price = 83, Raiting = 84, DEF = 34, DRI = 85, PAC = 82, PAS = 86, PHY = 80, SHO =  82},
                new FC {Name = "DE BRUYNE", Price = 32, Raiting = 91, DEF = 61, DRI = 87, PAC = 76, PAS = 92, PHY = 78, SHO = 86 },
                new FC {Name = "ALISSON", Price = 12, Raiting = 89, DEF = 52, DRI = 89, PAC = 85, PAS = 85, PHY = 90, SHO = 84 },
                new FC {Name = "INSIGNE", Price = 43, Raiting = 85, DEF = 25, DRI =89, PAC = 90, PAS = 82, PHY = 50, SHO = 74 },
                new FC {Name = "SIRIGU", Price = 44, Raiting = 82, DEF = 50, DRI = 81, PAC = 84, PAS = 76, PHY = 83, SHO = 76 },
                new FC {Name = "BENTANCUR", Price = 132, Raiting =79 , DEF = 70, DRI = 81, PAC =70 , PAS = 78, PHY = 74, SHO = 58 },
                new FC {Name = "DE GEA", Price = 23, Raiting = 89, DEF = 57, DRI =92 , PAC = 90, PAS = 81, PHY = 85, SHO = 84 }
               };
            return View(array);
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
