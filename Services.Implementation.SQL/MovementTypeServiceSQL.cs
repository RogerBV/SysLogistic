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
    public class MovementTypeServiceSQL : IMovementTypeService
    {
        public RegisteredMovementType Create(CreateMovementType newRegistry)
        {
            throw new NotImplementedException();
        }

        public RegisteredMovementType Delete(DeletedMovementType Id)
        {
            throw new NotImplementedException();
        }

        public List<RegisteredMovementType> List()
        {
            using (LogisticDataContext logisticDataContext = new LogisticDataContext())
            {
                return logisticDataContext.MovementTypes.ToList().Select(x => x.toDTO()).ToList();  
            }
                
        }

        public RegisteredMovementType Update(UpdateMovementType updateRegistry)
        {
            throw new NotImplementedException();
        }
    }
}
