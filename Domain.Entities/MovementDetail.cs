using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Entities
{
    public class MovementDetail
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public decimal Count { get; set; }
        public int MovementId { get; set; }
        [ForeignKey("MovementId")]
        public Movement Movement { get; set; }
    }
}
