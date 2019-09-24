﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
namespace Infraestructure.DataMapping
{
    public static class WarehouseDataMapping
    {
        public static Warehouse ToEntity(this CreateWarehouse newWarehouse)
        {
            return new Warehouse()
            {
                Name = newWarehouse.Name
                , Description = newWarehouse.Description
                , Lenght = 0
                , Latitude = 0
            };
        }
        public static RegisteredWarehouse toDTO(this Warehouse warehouseOnDb)
        {
            return new RegisteredWarehouse()
            {
                Name = warehouseOnDb.Name
                ,Description = warehouseOnDb.Description
                ,Length = warehouseOnDb.Lenght
                ,Latitude = warehouseOnDb.Latitude
            };
        }
    }
}
