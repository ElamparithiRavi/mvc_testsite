using System.Web.Mvc;

namespace testsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? time)
        {
            return View();
        }

        public ActionResult SleepFor(int? time)
        {
            if ((time ?? 0) > 0)
            {
                System.Threading.Thread.Sleep(time.Value);
                ViewBag.Message = string.Format("Slept for {0}ms", time);
            }

            return View("Sleep");
        }

        public ActionResult SleepRandom(int? min, int? max)
        {
            if(!min.HasValue || min.Value < 0) min = 50;
            if(!max.HasValue || max.Value < min.Value) max = min + 200;
            var rand = new System.Random();
            return SleepFor(rand.Next(min.Value, max.Value));
        }
    }
}
