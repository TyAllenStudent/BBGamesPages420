using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BBGamesPages420.Data;
using BBGamesPages420.Models;

namespace BBGamesPages420.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly BBGamesPages420.Data.ApplicationDbContext _context;

        public IndexModel(BBGamesPages420.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
