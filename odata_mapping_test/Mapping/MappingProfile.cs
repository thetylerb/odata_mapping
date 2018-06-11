using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using odata_mapping_test.Controllers.entities;
using odata_mapping_test.Core.Models;

namespace odata_mapping_test.Mapping
{
    public static class MappingProfile
    {
        public static void RegisterMappings() {
            Mapper.Initialize(cfg =>
            {

               cfg.CreateMap<Order, OrderEntity>();
               cfg.CreateMap<Product, ProductEntity>();
            });
        }
    }
}
