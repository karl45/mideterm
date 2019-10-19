using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetfirst.Data;
using aspnetfirst.Models.Players;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspnetfirst.Controllers
{
    public class PlayerController : Controller
    {
        private readonly PlayerContext _dbContext;

        public PlayerController(PlayerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var players = await _dbContext.players.ToListAsync();
            return View(players);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Player player)
        {


            _dbContext.players.Add(player);
            await _dbContext.SaveChangesAsync();

            var movies = await _dbContext.players.ToListAsync();

            return View("Index", movies);
        }

 
    }
}