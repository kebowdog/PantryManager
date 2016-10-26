using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PantryManager.Models
{
    public interface IPantryItem
    {
        Guid ID { get; set; }
        string Name { get; set; }
        Decimal Quantity { get; set; }
        DateTime ExpirationDate { get; set; }
        Pantry Pantry { get; set; }
    }
}
