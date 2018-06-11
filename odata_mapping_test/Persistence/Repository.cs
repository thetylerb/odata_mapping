using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using odata_mapping_test.Core.Models;

namespace odata_mapping_test.Persistence
{
    public class Repository
    {
        private readonly SalesContext context;

        public Repository(SalesContext context)
        {
            this.context = context;
        }

        public void SeedDatabase()
        {
            var customers = new Collection<Customer>()
            {
                new Customer() { CreditCardNumber = "CUST_1_CREDT_NUM", Email = "cust1@example.com", First = "cust_1_first", Last = "cust_1_last"},
                new Customer() { CreditCardNumber = "CUST_2_CREDT_NUM", Email = "cust2@example.com", First = "cust_2_first", Last = "cust_2_last"},
                new Customer() { CreditCardNumber = "CUST_3_CREDT_NUM", Email = "cust3@example.com", First = "cust_3_first", Last = "cust_3_last"},
                new Customer() { CreditCardNumber = "CUST_4_CREDT_NUM", Email = "cust4@example.com", First = "cust_4_first", Last = "cust_4_last"},
                new Customer() { CreditCardNumber = "CUST_5_CREDT_NUM", Email = "cust5@example.com", First = "cust_5_first", Last = "cust_5_last"},
            };

            context.Customers.AddRange(customers);

            var products = new Collection<Product>()
{
                new Product() { Name = "prod_1_name", Description = "prod_1_desc", Manufacturer = "prod_1_manufacturer", Price = 19.99 },
                new Product() { Name = "prod_2_name", Description = "prod_2_desc", Manufacturer = "prod_2_manufacturer", Price = 29.99 },
                new Product() { Name = "prod_3_name", Description = "prod_3_desc", Manufacturer = "prod_3_manufacturer", Price = 39.99 },
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var orders = new Collection<Order>()
            {
                new Order() { Clerk = "order_1_clerk", Customer = customers[0], Product = products[0], OrderDate = DateTime.Now },
                new Order() { Clerk = "order_2_clerk", Customer = customers[1], Product = products[0], OrderDate = DateTime.Now },
                new Order() { Clerk = "order_3_clerk", Customer = customers[2], Product = products[0], OrderDate = DateTime.Now },
                new Order() { Clerk = "order_4_clerk", Customer = customers[3], Product = products[0], OrderDate = DateTime.Now },
                new Order() { Clerk = "order_5_clerk", Customer = customers[4], Product = products[0], OrderDate = DateTime.Now },
                new Order() { Clerk = "order_6_clerk", Customer = customers[0], Product = products[1], OrderDate = DateTime.Now },
                new Order() { Clerk = "order_7_clerk", Customer = customers[1], Product = products[1], OrderDate = DateTime.Now },
                new Order() { Clerk = "order_8_clerk", Customer = customers[2], Product = products[1], OrderDate = DateTime.Now },
                new Order() { Clerk = "order_9_clerk", Customer = customers[3], Product = products[1], OrderDate = DateTime.Now },
                new Order() { Clerk = "order_10_clerk", Customer = customers[4], Product = products[1], OrderDate = DateTime.Now },
            };

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }

        public void DeleteData()
        {
            context.Products.RemoveRange(context.Products);
            context.Customers.RemoveRange(context.Customers);
            context.SaveChanges();
        }
    }
}
