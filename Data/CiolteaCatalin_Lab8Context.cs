using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CiolteaCatalin_Lab8.Models;

namespace CiolteaCatalin_Lab8.Data
{
    public class CiolteaCatalin_Lab8Context : DbContext
    {
        public CiolteaCatalin_Lab8Context (DbContextOptions<CiolteaCatalin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<CiolteaCatalin_Lab8.Models.Book> Book { get; set; }

        public DbSet<CiolteaCatalin_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<CiolteaCatalin_Lab8.Models.Category> Category { get; set; }
    }
}
