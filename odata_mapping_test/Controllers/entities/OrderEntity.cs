using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using odata_mapping_test.Core.Models;

namespace odata_mapping_test.Controllers.entities
{
    public class OrderEntity
    {
        public int Id { get; set; }
        public Double Price { get; set; }
        public DateTime OrderDate { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
