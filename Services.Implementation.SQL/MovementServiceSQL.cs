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
    public class MovementServiceSQL : IMovementService
    {
        public RegisteredMovement Create(CreateMovement newRegistry)
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                var eMovement = newRegistry.ToEntity();
                logisticDataContext.Movements.Add(eMovement);
                logisticDataContext.SaveChanges();
                return eMovement.ToDTO();
            }
        }

        public RegisteredMovement Delete(DeletedMovement Id)
        {
            throw new NotImplementedException();
        }

        public List<RegisteredMovement> List()
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                return logisticDataContext.Movements.ToList().Select(x => x.ToDTO()).ToList();
            }
        }

        public RegisteredMovement Update(UpdateMovement updateRegistry)
        {
            throw new NotImplementedException();
        }
    }
}
