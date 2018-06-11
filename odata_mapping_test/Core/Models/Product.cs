using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace odata_mapping_test.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Product() {
            Orders = new Collection<Order>();
        }
    }
}
