using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Data;

namespace PortfolioApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // Table of contents: all projects grouped by category.
        public IActionResult Index()
        {
            var grouped = ProjectData.All
                .GroupBy(p => p.Category)
                .OrderBy(g => g.Key)
                .ToList();

            return View(grouped);
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            return View();
        }
    }
}
