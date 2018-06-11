using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNet.OData;
using odata_mapping_test.Controllers.entities;
using odata_mapping_test.Core.Models;
using odata_mapping_test.Persistence;

namespace odata_mapping_test.Controllers
{
    public class OrdersController : ODataController
    {
        private readonly SalesContext context;

        public OrdersController(SalesContext context)
        {
            this.context = context;
        }

        [EnableQuery]
        public IQueryable<OrderEntity> Get()
        {
            return context.Orders
                .ProjectTo<OrderEntity>()
                .AsQueryable();
        }
    }   
}
