using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBGamesPages420.Models
{
    public class Game
    {
        public int ID { get; set; }

        public string GameTitle { get; set; }

        public DateTime GameDate { get; set; }

        public string Venue { get; set; }
        public string UserPaid { get; set; }
        public double PaidAmount { get; set; }
    }
}
