using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Filter;
using MVCDemo.Models;
using System.Diagnostics;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public string data { get; set; }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Hello(string name, string loc, string contact)
        {
           //  string myname = "Namratha Patil";
            ViewBag.UserName = name;
            ViewBag.Location = loc;
            ViewBag.Contact = contact;
            return View();
        }
        [Mylog]
        public string CSRetest()
        {
            return"#C retest is scheduled today @5PM;get prepared";
        }
       
      //  [ResponseCache(Duration = 10)]
        public String Retest()
        {
           
            return DateTime.Now.ToString();
        }
        // [Authorize]
        [Mylog]
         
        public string[] retests()
        {
            return new String[] { "c#=12-sep", "Tsql=13-sep" };
        }
        [Mylog]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}