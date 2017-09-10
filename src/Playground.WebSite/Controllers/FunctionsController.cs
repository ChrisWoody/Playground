using Microsoft.AspNetCore.Mvc;
using Playground.Core;
using Playground.Core.Messages;

namespace Playground.WebSite.Controllers
{
    public class FunctionsController : Controller
    {
        private readonly IStorageProvider _storageProvider;

        public FunctionsController()
        {
            _storageProvider = new StorageProvider();
        }

        public IActionResult TextToUpperCase()
        {
            return View();
        }

        [HttpPost]
        public async void PerformTextToUpperCase(string text)
        {
            await _storageProvider.PushMessageToQueue(new TextToUpperCaseMessage
            {
                Text = text
            });
        }
    }
}