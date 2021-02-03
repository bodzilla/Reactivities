using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Reactivities.Core.Models;

namespace Reactivities.Persistence
{
    public sealed class DataContext : DbContext
    {
        public DbSet<Value> Values { get; set; }

        public DataContext(DbContextOptions options)
            : base(options)
        {

        }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(new List<Value>
            {
                new Value
                {
                    Id = 1,
                    Name = "Value007"
                },
                new Value
                {
                    Id = 2,
                    Name = "Value121"
                },
                new Value
                {
                    Id = 3,
                    Name = "Value47"
                }
            });
        }
    }
}
