using Microsoft.AspNetCore.Mvc;
using MVC_Demo_2.Data;
using MVC_Demo_2.Models;

namespace MVC_Demo_2.Controllers
{
    public class ClubController : Controller
    {
        private readonly AplicationDbContex _dbContex;
        public ClubController(AplicationDbContex dbContext)
        { 
            _dbContex = dbContext;
        }

        public IActionResult  Club()
        {
            List<Club> club = _dbContex.Clubs.ToList();
            return View(club);
        }
    }
}
