﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Common;
namespace Domain.Entities
{
    public class Warehouse:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Lenght { get; set; }
        public decimal Latitude { get; set; }
    }
}
