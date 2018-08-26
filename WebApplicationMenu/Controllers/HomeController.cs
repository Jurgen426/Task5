using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplicationMenu.Models;


namespace WebApplicationMenu.Controllers
{
    public class HomeController : Controller
    {
        MenuContext db = new MenuContext();

        public ActionResult Index()
        {
            //var menu = db.Menus;
            //ViewBag.MyMenu = menu;

            List<Menu> menuItems = db.Menus.ToList();
            ViewBag.MyMenu = menuItems;
            return View(menuItems);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}