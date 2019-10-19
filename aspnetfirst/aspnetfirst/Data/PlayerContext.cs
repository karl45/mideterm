using aspnetfirst.Models.Players;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Data
{
    public class PlayerContext:DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options)
        {
        }
        public DbSet<Player> players { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(new Player
            {
                PlayerId = -1,
                Name = "Ronaldo",
                Skill = 95,
                Expirience = 85,
                TeamId = 1
            },
            new Player
            {
                PlayerId = -2,
                Name = "Messi",
                Skill = 93,
                Expirience = 79,
                TeamId = 2
            },
            new Player
            {
                PlayerId = -3,
                Name = "Robinho",
                Skill = 76,
                Expirience = 79,
                TeamId = 3
            }
            );
        }

    }
}
