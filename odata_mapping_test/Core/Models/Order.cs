using System;
using System.ComponentModel.DataAnnotations;

namespace odata_mapping_test.Core.Models
{   
    public class Order
    {
        public int Id { get; set; }
        public Double Price { get; set; }  
        public DateTime OrderDate { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }    
    }
}
