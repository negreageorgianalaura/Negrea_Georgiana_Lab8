using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Negrea_Georgiana_Lab8.Models;

namespace Negrea_Georgiana_Lab8.Data
{
    public class Negrea_Georgiana_Lab8Context : DbContext
    {
        public Negrea_Georgiana_Lab8Context (DbContextOptions<Negrea_Georgiana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Negrea_Georgiana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Negrea_Georgiana_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
