using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using odata_mapping_test.Core.Models;
using odata_mapping_test.Persistence;

namespace odata_mapping_test.Controllers
{
    public class CustomersController : ODataController   
    {
        private readonly SalesContext context;

        public CustomersController(SalesContext context) {
            this.context = context;
        }

        [EnableQuery]
        public IQueryable<Customer> Get()
        {
            return context.Customers.AsQueryable();
        }

    }
}
