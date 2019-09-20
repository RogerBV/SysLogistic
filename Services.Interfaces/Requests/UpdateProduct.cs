using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Requests
{
    public class UpdateProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
