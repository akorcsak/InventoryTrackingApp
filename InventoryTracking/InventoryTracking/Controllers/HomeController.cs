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


        public ActionResult List()
        {
            var modelInventory = (from p in _db.InventoryListTables
                                  orderby p.Id
                                  descending
                                  select p).ToList();


            return View(modelInventory);
        }

        public ActionResult Inventory()
        {
            var modelInventory = (from p in _db.InventoryListTables
                                  orderby p.Id
                                  descending
                                  select p).ToList();


            return View(modelInventory);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View(new InventoryListTable());
        }

        [HttpPost]
        public ActionResult Create(InventoryListTable newItem)
        {
            var q = _db.InventoryListTables;
            q.Add(newItem);
            _db.SaveChanges();


            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var inventory = _db.InventoryListTables.Where(s => s.Id == Id).FirstOrDefault();

            return View(inventory);

        }


        [HttpPost]
        public ActionResult Edit(InventoryListTable editedItem)
        {
            var q = _db.InventoryListTables;

            var inventoryItem = q.Where(s => s.Id == editedItem.Id).FirstOrDefault();
            q.Remove(inventoryItem);
            q.Add(editedItem);
            _db.SaveChanges();

            return RedirectToAction("List");
        }
    }
}