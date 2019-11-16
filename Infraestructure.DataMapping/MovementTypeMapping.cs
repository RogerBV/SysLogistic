using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Services.Interfaces.Responses;
namespace Infraestructure.DataMapping
{
    public static class MovementTypeMapping
    {
        public static RegisteredMovementType toDTO(this MovementType movementType)
        {
            return new RegisteredMovementType()
            {
                Id = movementType.Id
                ,Name = movementType.Name
            };
        }
    }
}
