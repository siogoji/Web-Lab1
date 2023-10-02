using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class TrainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
