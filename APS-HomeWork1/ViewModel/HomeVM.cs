using Microsoft.AspNetCore.Mvc;

namespace APS_HomeWork1.ViewModel
{
    public class HomeVM : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
