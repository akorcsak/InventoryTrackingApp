using System.Data.Entity;

namespace InventoryTracking.Models
{
    public class DB : DbContext
    {
        public DB() : base("DefaultConnection")
        {
        }

        public DbSet<InventoryListTable> InventoryListTables { get; set; }

    }
}
