using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Models;

namespace DAL
{
    public class FruitContext: DbContext
    {
        public DbSet<Fruits> Fruits { get; set; }

        public FruitContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
