using Microsoft.AspNetCore.Mvc;

namespace SampleAzureWebApp.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
