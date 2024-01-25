using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab_1_Lokesh.Models;

namespace Lab_1_Lokesh.Data
{
    public class Lab_1_LokeshContext : DbContext
    {
        public Lab_1_LokeshContext (DbContextOptions<Lab_1_LokeshContext> options)
            : base(options)
        {
        }

        public DbSet<Lab_1_Lokesh.Models.LokeshMovie> LokeshMovie { get; set; } = default!;
    }
}
