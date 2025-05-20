using Microsoft.AspNetCore.Mvc;

namespace SampleAzureWebApp.Controllers
{
    // Deploying for testing
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
