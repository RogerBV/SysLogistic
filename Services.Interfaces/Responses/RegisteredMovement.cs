using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Responses
{
    public class RegisteredMovement
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int MovementTypeId { get; set; }
        public DateTime MovementDate { get; set; }
        public List<RegisteredMovementDetail> ListDetails { get; set; }
        
    }
}
