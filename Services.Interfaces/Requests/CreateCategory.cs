using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Requests
{
    public class CreateCategory
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
