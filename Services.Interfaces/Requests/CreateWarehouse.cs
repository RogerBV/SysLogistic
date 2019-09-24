using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Requests
{
    public class CreateWarehouse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Length { get; set; }
        public decimal Latitude { get; set; }

        public DateTime CreationDate { get; set; }

    }
}
