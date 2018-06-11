using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;
using odata_mapping_test.Core.Models;

namespace odata_mapping_test.Persistence
{
    public class SalesModelBuilder
    {
        public IEdmModel GetEdmModel(IServiceProvider serviceProvider)
        {
            var builder = new ODataConventionModelBuilder(serviceProvider);

            builder.EntitySet<Customer>("Customers")
                .EntityType
                .Expand();
            builder.EntitySet<Order>("Orders")
                .EntityType
                .Expand();
            builder.EntitySet<Product>("Products");

            return builder.GetEdmModel();
        }
    }
}
