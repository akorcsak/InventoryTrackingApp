using InventoryTracking.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace InventoryTracking.Controllers
{
    public class HomeController : Controller
    {
        private static DB _db = null;

        public HomeController()
        {
            if(_db == null) _db = new DB(); //singleton
        }

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

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var inventory = _db.InventoryListTables.Where(s => s.Id == Id).FirstOrDefault();

            return View(inventory);

        }


        [HttpPost]
        public ActionResult Delete(InventoryListTable deletedItem)
        {
            var q = _db.InventoryListTables;

            var inventoryItem = q.Where(s => s.Id == deletedItem.Id).FirstOrDefault();
            q.Remove(inventoryItem);
            _db.SaveChanges();


            return RedirectToAction("List");   

        }


        [HttpGet]
        public ActionResult Export()
        {
            var modelInventories = from p in _db.InventoryListTables
                                  orderby p.Id
                                  descending
                                  select p;
            //List<string> stringList = modelInventory.Select().ToList();

            MemoryStream stream = null;

            if (modelInventories?.Count() > 0)
            {
                var sb = new StringBuilder();
                foreach (var modelInventory in modelInventories)
                {
                    sb.AppendLine($"{modelInventory.Item_name},{modelInventory.Stock},{modelInventory.Price}");
                }

                stream = new MemoryStream(Encoding.ASCII.GetBytes(sb.ToString()));
            }

            if (stream == null)
            {
                stream = new MemoryStream();
            }

            return new FileStreamResult(stream, "text/plain")
            {
                FileDownloadName = "Inventory_List.csv"
            };

        }

    }
}