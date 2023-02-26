using APS_HomeWork1.Models;
using Microsoft.AspNetCore.Mvc;

namespace APS_HomeWork1.ViewModel
{
    public class HomeVM : Controller
    {
        public List<Game> Games { get; set; }
        public List<Category> Categories { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
