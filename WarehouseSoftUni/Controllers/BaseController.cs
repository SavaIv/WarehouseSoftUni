using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WarehouseSoftUni.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
