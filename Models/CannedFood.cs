using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PantryManager.Models
{
    public class CannedFood : IPantryItem
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Brand { get; set; }
        public decimal Weight { get; set; }
        public decimal ServingsPerContainer { get; set; }
        public Pantry Pantry { get; set; }
    }
}
