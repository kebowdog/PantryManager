using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PantryManager.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Pantry> Pantries { get; set; }
    }
}
