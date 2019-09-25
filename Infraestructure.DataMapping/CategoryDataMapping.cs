using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Services.Interfaces.Declarations;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
namespace Infraestructure.DataMapping
{
    public static class CategoryDataMapping
    {
        public static Category ToEntity(this CreateCategory newCategory)
        {
            return new Category()
            {
                Name = newCategory.Name
                , Description = newCategory.Description
                , CreationDate = newCategory.CreationDate
            };
        }
        public static RegisteredCategory toDTO(this Category categoryOnDb)
        {
            return new RegisteredCategory()
            {
                Id = categoryOnDb.Id
                ,
                Name = categoryOnDb.Name
                ,
                Description = categoryOnDb.Description
            };
        }
        public static Category ToEntity(this UpdateCategory updateCategory)
        {
            return new Category()
            {
                Id = updateCategory.Id
                ,
                Name = updateCategory.Name
                , Description = updateCategory.Description
            };
        }
    }
}
