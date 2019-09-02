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
    public class CategoryServiceSQL : ICategoryService
    {
        public RegisteredCategory Create(CreateCategory newRegistry)
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                var newCategory = newRegistry.ToEntity();
                logisticDataContext.Categories.Add(newCategory);
                logisticDataContext.SaveChanges();
                return newCategory.toDTO();
            }
        }

        public RegisteredCategory Delete(DeletedCategory Id)
        {
            throw new NotImplementedException();
        }

        public List<RegisteredCategory> List()
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                return logisticDataContext.Categories.ToList().Select(x => x.toDTO()).ToList();
            }
        }

        public RegisteredCategory Update(UpdateCategory updateRegistry)
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                var categoryToUpdate = updateRegistry.ToEntity();
                logisticDataContext.Categories.Attach(categoryToUpdate);
                logisticDataContext.Entry(categoryToUpdate).State = System.Data.Entity.EntityState.Modified;
                logisticDataContext.SaveChanges();
                return categoryToUpdate.toDTO();
            }
        }
    }
}
