using Microsoft.AspNetCore.Mvc;
using TeznoProject.Models;

namespace TeznoProject.Areas.TenzoAdmin.Controllers
{
    [Area("TenzoAdmin")]
    public class DashboardController : Controller
    {
        private readonly TenzoDBContext _context;

        public DashboardController(TenzoDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
