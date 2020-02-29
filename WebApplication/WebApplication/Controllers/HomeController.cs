using System.IO;
using System.Threading;
using System.Web.Mvc;
using System.Xml.Serialization;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private Card card;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hang()
        {
            Threads();
            return Content("Hang!");
        }

        public ActionResult Sleep()
        {
            Thread.Sleep(300000);
            return Content("Sleep!");
        }

        public ActionResult MemoryLeak()
        {
            card = new Card();
            for (var x = 0; x <= 1000000; x++)
            {
                // serialize a model class, but forget to dispose it.
                var stream = new MemoryStream();
                var serializer = new XmlSerializer(typeof(Product));
                serializer.Serialize(stream, new Product());
                card = new Card();
            }

            return Content("Memory Leaked!");
        }

        private static void Threads()
        {
            for (var x = 0; x < 500; x++)
            {
                ThreadPool.QueueUserWorkItem(y => Thread.Sleep(60000));
            }
        }

        public ActionResult StackOverflow()
        {
            So();
            return Content("Crash!");
        }

        private static void So()
        {
            So();
        }
    }
}