using Microsoft.AspNetCore.Mvc;

namespace CAOVANUYBTH2.Controllers
{
    public class EmployeeController : Controller 
    {public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string Tenban)
        {
            string strReturn = "Hello" + Tenban;
            ViewBag.abc = strReturn;
            return View();
        }
    }

}