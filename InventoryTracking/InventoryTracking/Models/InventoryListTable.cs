using System.ComponentModel.DataAnnotations;

namespace InventoryTracking.Models
{
    public class InventoryListTable
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Item Name")]
        public string Item_name { get; set; }

        public int Stock { get; set; }

        public string Price { get; set; }
    }
}