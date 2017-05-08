using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerManagement.Controllers
{
    public class 客戶清單Controller : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: 客戶清單
        public ActionResult Index()
        {
            return View(db.客戶清單.ToList());
        }
    }
}