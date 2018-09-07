using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasicApp.Models
{
    public class Items
    {
        public int id { get; set; }
        public string itemName { get; set; }
    }

    public class ItemDatabase : List<Items>
    {
        public ItemDatabase()
        {
            Add(new Items() { id = 1, itemName = "Item1" });
            Add(new Items() { id = 2, itemName = "Item2" });
            Add(new Items() { id = 3, itemName = "Item3" });
            Add(new Items() { id = 4, itemName = "Item4" });
            Add(new Items() { id = 5, itemName = "Item5" });
            Add(new Items() { id = 6, itemName = "Item6" });
            Add(new Items() { id = 7, itemName = "Item7" });
        }
    }
}