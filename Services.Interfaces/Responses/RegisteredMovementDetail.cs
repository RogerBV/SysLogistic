using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Responses
{
    public class RegisteredMovementDetail
    {
        public int Id { get; set; }
        public decimal Count { get; set; }
        public int ProductId { get; set; }
    }
}
