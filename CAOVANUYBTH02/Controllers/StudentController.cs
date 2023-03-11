using Microsoft.AspNetCore.Mvc;

namespace CAOVANUYBTH2.Controllers
{
    public class StudentController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(string FullName)
        {
            string strReturn = "Hello" + FullName;
            ViewBag.Thongbao = strReturn;
            return View();
        }
    }

}
