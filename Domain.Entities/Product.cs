using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Common;
namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public int Product_Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}
