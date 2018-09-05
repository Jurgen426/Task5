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
            
            ViewBag.Message = CreateMenu(0);
            return View();
        }
        public string CreateMenu(int Parent)
        {
            //bool IsExist = false;
            List<Menu> menuItems = db.Menus.ToList();
            string res = "";

            ////проверка на существование вложенных пунктов
            //foreach (var i in menuItems)
            //{
            //    if (i.ParentId == Parent)
            //    {
            //        IsExist = true;
            //    }

            //}


            //if (IsExist)
            //{
                if (Parent == 0)
                {
                    res += "<ul id=\"navbar1\">";
                }
                else
                {
                    res += "<ul>";
                }
                foreach (var item in menuItems)
                {
                    if (item.ParentId == Parent)
                    {
                        res += "<li><a href = \"\">" + item.Name + " </a>";
                        res += CreateMenu(item.Id);
                        res += "</li>";
                    }
                }
                res += "</ul>";

            //}
            return res;

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