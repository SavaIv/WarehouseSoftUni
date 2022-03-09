using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Warehouse.Core.Constants;
using WarehouseSoftUni.Models;

namespace WarehouseSoftUni.Controllers
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
            ViewData[MessageConstant.SuccessMessage] = "Всичко е ОК. Продължавай нататък.";

            return View();
        }

        public IActionResult Privacy([FromBody] ErrorViewModel error)
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