using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Entities;
namespace Infraestructure.SQLERepository
{
    public class LogisticDataContext:DbContext
    {
        private static readonly string DatabaseConnectionStringName = "LogisticDB";
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public LogisticDataContext() : base(DatabaseConnectionStringName)
        {
        }
    }
}
