using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Entities
{
    public class Movement : BaseEntity
    {
        public int WarehouseId { get; set; }
        [ForeignKey("WarehouseId")]
        public Warehouse Warehouse { get; set; }
        public int MovementTypeId { get; set; }
        [ForeignKey("MovementTypeId")]
        public MovementType MovementType { get; set; }
        public DateTime MovementDate { get; set; }

        public List<MovementDetail> Details { get; set; }
    }
}
