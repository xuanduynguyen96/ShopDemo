using Microsoft.AspNetCore.Mvc;
using ShopDemo.Models;
using ShopDemo.Models.Domain;
using ShopDemo.ViewModels;
using System.Diagnostics;

namespace ShopDemo.Controllers
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
            var user = new User { Name = "Xuan Duy", Role = "Normal" };
            var itemList = new List<Item>
            {
                new() { Name = "Shirt", Quantity = 10, Color = "White" },
                new() { Name = "Polo", Quantity = 5, Color = "Red" }
            };

            var viewModel = new HomeViewModel
            {
                User = user,
                Items = itemList
            };

            return View(viewModel);
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
