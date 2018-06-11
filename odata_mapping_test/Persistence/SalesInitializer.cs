using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using odata_mapping_test.Core.Models;

namespace odata_mapping_test.Persistence
{
    public static class SalesInitializer
    {
        private static bool _initialized = false;
        private static object _lock = new object();
        private static List<Product> products;
        private static List<Order> orders;

        public static void Seed(SalesContext context)
        {
            SeedDatabase(context);
        }


        internal static void Initialize(SalesContext context)
        {
            if (!_initialized) {
                lock (_lock) {
                    if (_initialized)
                        return;

                    InitializeData(context);
                }
            }
        }

        internal static void Reset(SalesContext context)
        {
            ResetDatabase(context);
        }

        private static void InitializeData(SalesContext context) {
            Seed(context);
        }

        private static void SeedDatabase(SalesContext context)
        {
            var products = new Collection<Product>()
            {
                new Product() { Name = "prod_1_name", Description = "prod_1_desc",},
                new Product() { Name = "prod_2_name", Description = "prod_2_desc",},
                new Product() { Name = "prod_3_name", Description = "prod_3_desc",},
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var orders = new Collection<Order>()
            {
                new Order() { Product = products[0], Price = 1.99, OrderDate = DateTime.Now },
                new Order() { Product = products[1], Price = 2.99, OrderDate = DateTime.Now },
                new Order() { Product = products[2], Price = 3.99, OrderDate = DateTime.Now },
                new Order() { Product = products[0], Price = 4.99, OrderDate = DateTime.Now },
                new Order() { Product = products[1], Price = 5.99, OrderDate = DateTime.Now },
                new Order() { Product = products[2], Price = 6.99, OrderDate = DateTime.Now },
            };

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }

        private static void ResetDatabase(SalesContext context)
        {
            context.Products.RemoveRange(context.Products);
            context.SaveChanges();
        }
    }
}
