using aspnetfirst.Models.Teams;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Data
{
    public class TeamContext:DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options)
        {
        }
        public DbSet<Team> teams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(new Team
            {
                TeamId = 1,
                Name = "Juventus",
                Description = "Italian club",
                Coach = "Dias"

            },
            new Team
            {
                TeamId = 2,
                Name = "Barcelona",
                Description = "Spain club",
                Coach = "Moriis"
            },
            new Team
            {
                TeamId = 3,
                Name = "Barcelona",
                Description = "Spain club",
                Coach = "Moriis"
            }
            );
        }
    }
}
