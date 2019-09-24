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
namespace Services.Implementation.SQL
{
    public class WarehouseServiceSQL : IWarehouseService
    {
        public RegisteredWarehouse Create(CreateWarehouse newRegistry)
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                var newWareHouse = newRegistry.ToEntity();
                logisticDataContext.Warehouses.Add(newWareHouse);
                logisticDataContext.SaveChanges();
                return newWareHouse.toDTO();
            }
        }

        public RegisteredWarehouse Delete(DeletedWarehouse Id)
        {
            throw new NotImplementedException();
        }

        public List<RegisteredWarehouse> List()
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                return logisticDataContext.Warehouses.ToList().Select(x => x.toDTO()).ToList();
            }
        }

        public RegisteredWarehouse Update(UpdatedWarehouse updateRegistry)
        {
            throw new NotImplementedException();
        }
    }
}
