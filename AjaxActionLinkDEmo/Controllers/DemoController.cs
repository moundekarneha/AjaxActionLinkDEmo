using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace AjaxActionLinkDEmo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult GetCountry()
        {
            List<String> list = new List<string>()
            {
                "India","US","America"
            };

            var data = JsonConvert.SerializeObject(list);   
            return Json(data,JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetState()
        {
            List<String> list = new List<string>()
            {
                "Maharashtra","Gujarat","Chattisgad"
            };
            var data = JsonConvert.SerializeObject(list);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCity()
        {
            List<String> list = new List<string>()
            {
                "Nagpur","Yawtmal","Washim"
            };
            var data = JsonConvert.SerializeObject(list);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}