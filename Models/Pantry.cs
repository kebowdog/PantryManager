using System;
using System.Collections.Generic;

namespace PantryManager.Models
{
    public class Pantry
    {
        public Guid ID { get; set; }
        public User Owner { get; set; }
        public ICollection<IPantryItem> Items { get; set; }
    }
}