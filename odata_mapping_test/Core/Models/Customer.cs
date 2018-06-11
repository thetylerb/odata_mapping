using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace odata_mapping_test.Core.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new Collection<Order>();
        }
    }
}
