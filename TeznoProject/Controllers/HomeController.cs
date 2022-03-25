using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TeznoProject.Models;
using TeznoProject.ViewModels;

namespace TeznoProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TenzoDBContext _context;



        public HomeController(ILogger<HomeController> logger, TenzoDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            HomeVM vm = new()
            {
                Sliders = _context.Sliders.ToList(),
                Products = _context.Products.ToList(),
                Offers = _context.Offers.ToList(),
                News = _context.News.FirstOrDefault(),
               
        };
            return View(vm);
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