using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces.Requests;
using Services.Interfaces.Responses;
using Services.Interfaces.Declarations.Common;
namespace Services.Interfaces.Declarations
{
    public interface IProductService:
        ICRUDService<CreateProduct, UpdateProduct, RegisteredProduct, DeletedProduct>
    {
    }
}
