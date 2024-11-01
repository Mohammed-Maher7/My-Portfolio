using Microsoft.AspNetCore.Mvc;
using My_Portfolio.Model;

namespace My_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HOME()
        {
            return View();
        }

        public ActionResult ABOUTME()
        {
            return View();
        }

        public ActionResult SKILLS()
        {
            return View();
        }

        public ActionResult PROJRCTS()
        {
            return View();
        }

        public ActionResult CONTACTME()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SUBMIT(SubmitionForm form)
        {
            return RedirectToAction("AFTERSUMBIT");
        }

        public ActionResult AFTERSUMBIT()
        {
            return View();
        }
    }
}

        
        