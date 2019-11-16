using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Requests
{
    public class UpdateMovement
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int MovementTypeId { get; set; }
        public DateTime MovementDate { get; set; }
        public List<MovementDetail> ListDetails { get; set; }
        public class MovementDetail
        {
            private int ProductId { get; set; }
            public decimal Count { get; set; }

        }
    }
}
