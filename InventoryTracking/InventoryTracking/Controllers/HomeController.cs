using InventoryTracking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryTracking.Controllers
{
    public class HomeController : Controller
    {
        DB _db = new DB();
        public ActionResult InventoryList()
        {
            var modelInventory = (from p in _db.InventoryListTables
                                orderby p.Id
                                descending
                                select p).ToList();


            return View(modelInventory);
        }

    }
}