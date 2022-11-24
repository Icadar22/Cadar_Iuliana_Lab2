using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cadar_Iuliana_Lab2.Models;

namespace Cadar_Iuliana_Lab2.Data
{
    public class Cadar_Iuliana_Lab2Context : DbContext
    {
        public Cadar_Iuliana_Lab2Context (DbContextOptions<Cadar_Iuliana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cadar_Iuliana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cadar_Iuliana_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Cadar_Iuliana_Lab2.Models.Author> Author { get; set; }

        public DbSet<Cadar_Iuliana_Lab2.Models.Category> Category { get; set; }

        public DbSet<Cadar_Iuliana_Lab2.Models.Borrowing> Borrowing { get; set; }

        public DbSet<Cadar_Iuliana_Lab2.Models.Member> Member { get; set; }
    }
}
