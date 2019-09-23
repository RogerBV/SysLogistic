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
    public static class ProductDataMapping
    {
        public static Product ToEntity(this CreateProduct newProduct)
        {
            return new Product()
            {
                Name = newProduct.Name
                , Description = newProduct.Description
                , CategoryId = newProduct.CategoryId
                , Price = newProduct.Price
                , CreationDate = newProduct.CreationDate
            };
        }
        public static RegisteredProduct toDTO(this Product productOnDb)
        {
            return new RegisteredProduct()
            {
                Id = productOnDb.Id
                , Name = productOnDb.Name
                , Description = productOnDb.Description
                , Price = productOnDb.Price
                , categoryName = productOnDb.Category != null ? productOnDb.Category.Name : ""
            };
        }
    }
}
