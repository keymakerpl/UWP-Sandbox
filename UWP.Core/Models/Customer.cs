using System.Collections.Generic;

namespace UWP.Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Symbol { get; set; }

        public List<Order> OrdersList { get; set; }
    }
}
