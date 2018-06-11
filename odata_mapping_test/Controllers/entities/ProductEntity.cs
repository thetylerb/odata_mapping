using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using odata_mapping_test.Core.Models;

namespace odata_mapping_test.Controllers.entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<OrderEntity> Orders { get; set; }
    }
}
