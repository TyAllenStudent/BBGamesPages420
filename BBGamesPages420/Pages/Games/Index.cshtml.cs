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

        public enum SortByTime
        {
            AllGames,
            FutureGames,
            PastGames
        }

        private readonly BBGamesPages420.Data.ApplicationDbContext _context;

        public IndexModel(BBGamesPages420.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public SortByTime Sorting { get; set; }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync(SortByTime sorting = SortByTime.FutureGames)
        {
            Sorting = sorting;

            if (sorting == SortByTime.FutureGames)
            {

                Game = await _context.Game.Where(f => f.GameDate > DateTime.Today).ToListAsync();

            }

            else
            {
                Game = await _context.Game.ToListAsync();
            }

        }

    }
}
