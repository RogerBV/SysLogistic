using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Requests
{
    public class CreateMovement
    {
        public int WarehouseId { get; set; }
        public int MovementTypeId { get; set; }
        public DateTime MovementDate { get; set; }

        public List<CreateMovementDetail> ListDetails { get; set; }

    }
}
