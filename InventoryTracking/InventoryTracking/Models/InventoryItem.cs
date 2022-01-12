using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryTracking.Models
{
    public class InventoryItem
    {
        [Key]
        public int Id { get; set; }

        public string Item_name { get; set; }

        public string Stock { get; set; }

        public string Price { get; set; }
    }
}