using Microsoft.AspNetCore.Mvc;

namespace WarehouseSoftUni.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
