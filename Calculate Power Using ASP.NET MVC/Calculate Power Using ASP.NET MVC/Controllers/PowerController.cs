using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class PowerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Index(Power obj) {
            int ans = obj.b;
            int basevalue = obj.b;
            int powervalue = obj.p;
            for(int i = 2; i <= powervalue; i++)
            {
                ans = ans * basevalue;
            }
            ViewBag.result = "Answer is " + ans;
            return View();
        }
    }
}
