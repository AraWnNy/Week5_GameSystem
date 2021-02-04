using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    class Gamer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string IdentityNumber { get; set; }
        public List<Game> UserGames { get; }

        public Gamer()
        {
            UserGames = new List<Game>();
        }
    }
}
