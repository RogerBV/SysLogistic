
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Requests
{
    public class CreateMovementDetail
    {
        public int ProductId { get; set; }
        public decimal Count { get; set; }
    }
}
