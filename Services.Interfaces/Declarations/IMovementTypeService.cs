using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces.Declarations.Common;
using Services.Interfaces.Responses;
using Services.Interfaces.Requests;
namespace Services.Interfaces.Declarations
{
    public interface IMovementTypeService:ICRUDService<CreateMovementType,UpdateMovementType,RegisteredMovementType,DeletedMovementType>
    {
    }
}
