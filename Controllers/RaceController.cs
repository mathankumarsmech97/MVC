using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo_2.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Race()
        {
            return View();
        }
    }
}
