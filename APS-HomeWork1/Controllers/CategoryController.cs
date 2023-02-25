using APS_HomeWork1.Models;
using Microsoft.AspNetCore.Mvc;

namespace APS_HomeWork1.Controllers
{
    public class CategoryController : Controller
    {
        public List<Category> Categories;
        public CategoryController() 
        {
            Categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Sandbox"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Shooters (FPS and TPS)"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Role-playing (RPG, ARPG, and More)"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Action-adventure"
                },
            };
        }
        public ViewResult Index()
        {
            return View(Categories);
        }
    }
}
