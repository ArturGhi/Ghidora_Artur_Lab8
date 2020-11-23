using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ghidora_Artur_Lab8.Models;

namespace Ghidora_Artur_Lab8.Data
{
    public class Ghidora_Artur_Lab8Context : DbContext
    {
        public Ghidora_Artur_Lab8Context (DbContextOptions<Ghidora_Artur_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ghidora_Artur_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ghidora_Artur_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ghidora_Artur_Lab8.Models.Category> Category { get; set; }
    }
}
