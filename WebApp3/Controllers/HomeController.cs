using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using WebApp3.Models;
using WebApp3.Newfolder;

namespace WebApp3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        InvenViewModel invent;
       
        public HomeController(ILogger<HomeController> logger)
        {
            
            _logger = logger;
            invent = new InvenViewModel();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            
            if (username.Equals(Admin.Username) & password.Equals(Admin.Password))
            {
                return Redirect("~/Home/Inventory");
            }
            else return Redirect("~/Home/Login");
        }


        [HttpGet]
        public IActionResult Inventory()
        {
            
            
            return View(invent);
        }
            
        [HttpPost]
        public IActionResult Inventory(InvenViewModel invent)
        {
            
          
            if (DataBase.One > invent.One )
            {
                ViewData["Color1"] = "#FF0000";
                
            }
           if(DataBase.One == invent.One)
            {
                ViewData["Color1"] = "#008000";
            }
             if (DataBase.Two > invent.Two)
             {
                ViewData["Color2"] = "#FF0000";
                
             }
            if (DataBase.Two == invent.Two)
            {
                ViewData["Color2"] = "#008000";

            }
            if (DataBase.Three > invent.Three)
           {
                ViewData["Color3"] = "#FF0000";
               
           }
            if (DataBase.Three == invent.Three)
            {
                ViewData["Color3"] = "#008000";

            }
            if (DataBase.Four > invent.Four)
            {
                ViewData["Color4"] = "#FF0000";
                
            }
            if (DataBase.Four == invent.Four)
            {
                ViewData["Color4"] = "#008000";

            }
            if (DataBase.Five > invent.Five)
            {
                ViewData["Color5"] = "#FF0000";

            }
            if (DataBase.Five == invent.Five)
            {
                ViewData["Color5"] = "#008000";

            }


            return View(invent);
        }
        [HttpGet]
        public IActionResult Login()
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