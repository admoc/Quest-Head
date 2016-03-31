using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QuestHeadProject.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class ItemDBCtxt : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}