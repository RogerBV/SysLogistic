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
    public static class MovementDetailDataMapping
    {
        public static MovementDetail ToEntity(this CreateMovementDetail createMovementDetail)
        {
            return new MovementDetail()
            {
                Count = createMovementDetail.Count
                ,
                ProductId = createMovementDetail.ProductId

            };
        }
        public static RegisteredMovementDetail ToDTO(this MovementDetail movementDetail)
        {
            return new RegisteredMovementDetail()
            {
                ProductId = movementDetail.ProductId
                ,
                Count = movementDetail.Count
                ,
                Id = movementDetail.Id
            };
        }
    }
}
