using Microsoft.AspNetCore.Mvc;

namespace PhysicianReferralsWeb.Controllers
{
    public class ReferralsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Create()
        {
            return View();
        }


        public IActionResult Details()
        {
            return View();
        }
    }
}