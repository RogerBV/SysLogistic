using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces.Declarations;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using Infraestructure.SQLERepository;
using Infraestructure.DataMapping;
using Domain.Entities;
namespace Services.Implementation.SQL
{
    public class ProductServiceSQL : IProductService
    {
        public RegisteredProduct Create(CreateProduct newRegistry)
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                var newProduct = newRegistry.ToEntity();
                logisticDataContext.Products.Add(newProduct);
                logisticDataContext.SaveChanges();
                return newProduct.toDTO();
            }
        }

        public RegisteredProduct Delete(DeletedProduct Id)
        {
            throw new NotImplementedException();
        }

        public List<RegisteredProduct> List()
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                return logisticDataContext.Products.Include("Category").ToList().Select(x => x.toDTO()).ToList();
            }
        }

        public RegisteredProduct Update(UpdateProduct updateRegistry)
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                var productToEntity = updateRegistry.ToEntity();
                logisticDataContext.Products.Attach(productToEntity);
                logisticDataContext.Entry(productToEntity).State = System.Data.Entity.EntityState.Modified;
                logisticDataContext.SaveChanges();
                return productToEntity.toDTO();
            }
        }
    }
}
