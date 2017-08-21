using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTool.Models;

namespace WebTool.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData() {
            return View("Index",Models.TestCase.getData());
        }

        [HttpGet]
        public JsonResult AjaxMethod()
        {
            PersonModel person = new PersonModel
            {
                Name = "Rohit",
                DateTime = DateTime.Now.ToString()
            };
            return Json(person,JsonRequestBehavior.AllowGet);
        }
    }
}