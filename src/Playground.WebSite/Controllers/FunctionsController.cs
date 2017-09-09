using Microsoft.AspNetCore.Mvc;

namespace Playground.WebSite.Controllers
{
    public class FunctionsController : Controller
    {
        public IActionResult TextToUpperCase()
        {
            return View();
        }

        [HttpPost]
        public async void PerformTextToUpperCase(string text)
        {
            // send request via queue storage
        }
    }
}