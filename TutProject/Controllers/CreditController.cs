using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutProject.Models;

namespace TutProject.Models
{
    public class CreditController : Controller
    {
        // GET: Credit
        public ActionResult Index()
        {
            return View(new TakeСredit());
        }

       [HttpPost]

        public ActionResult Contact(TakeСredit puk, string btn1)
        {
            if (btn1 == "btn1") 
            {
                
            }

            return View(puk);
        }

    }
}