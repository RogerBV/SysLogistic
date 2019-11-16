using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
namespace Infraestructure.DataMapping
{
    public static class MovementDataMapping
    {
        public static Movement ToEntity(this CreateMovement createMovement)
        {
            return new Movement()
            {
                MovementDate = createMovement.MovementDate
                ,WarehouseId = createMovement.WarehouseId
                ,MovementTypeId = createMovement.MovementTypeId
                ,Details = createMovement.ListDetails.ToList().Select( x => x.ToEntity() ).ToList()
            };
        }
        public static RegisteredMovement ToDTO(this Movement movement)
        {
            return new RegisteredMovement()
            {
                MovementDate = movement.MovementDate
                ,
                WarehouseId = movement.WarehouseId
                ,
                MovementTypeId = movement.MovementTypeId
                ,
                ListDetails = movement.Details.ToList().Select(x => x.ToDTO()).ToList()
            };
        }
    }
}
