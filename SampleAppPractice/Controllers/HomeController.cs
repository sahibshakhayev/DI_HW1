using Microsoft.AspNetCore.Mvc;
using SampleAppPractice.Models;

namespace SampleAppPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string message)
        {

            var messageFactory = new MessageFactory();
            var settings = new SmtpSettings()
            {
                Host = "smtp.example.com",
                Port = 25
            };
            var smtpClient = new SmtpClient(settings);
            var messanger = new Messanger(smtpClient, messageFactory);

            messanger.SendMessage(message, "admin@example.com");

            return View();
        }
    }
}
