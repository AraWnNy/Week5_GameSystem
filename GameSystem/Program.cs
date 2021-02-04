using System;
using System.Collections.Generic;

namespace GameSystem
{
    class Program
    {
        static Gamer gamer;
        static GamerManager gamerManager;
        static Library gameLibrary;
        static GameLibraryManager libraryManager;
        static SalesMananger salesMananger;
        static CampaignManager campaignManager;
        static void Main(string[] args)
        {
            CreateGameLibrary();

            CreateNewUser();
            gamerManager = new GamerManager(new GamerValidationManager());

            /*gamerManager.Add(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Update(gamer);*/

            //gamerManager.ShowGameLibrary(gamer);

            Campaign();
            Sales();

            //gamerManager.ShowGameLibrary(gamer);

            Console.Read();
        }

        static void CreateNewUser()
        {
            gamer = new Gamer();
            gamer.ID = 1;
            gamer.FirstName = "Fikret";
            gamer.LastName = "Gözütok";
            gamer.BirthYear = 2000;
            gamer.IdentityNumber = "12345";
        }

        static void CreateGameLibrary()
        {
            gameLibrary = new GameLibrary();
            libraryManager = new GameLibraryManager(gameLibrary);

            Game g1 = new Game { GameID = 1, GameName = "GTA V", Price = 160 };
            Game g2 = new Game { GameID = 2, GameName = "Tomb Raider", Price = 80 };
            Game g3 = new Game { GameID = 3, GameName = "Rainbow Six Siege", Price = 100 };
            Game g4 = new Game { GameID = 4, GameName = "CS:GO", Price = 75 };
            Game g5 = new Game { GameID = 5, GameName = "CyberPunk 2077", Price = 250 };

            libraryManager.Add(g1);
            libraryManager.Add(g2);
            libraryManager.Add(g3);
            libraryManager.Add(g4);
            libraryManager.Add(g5);

        }

        static void Sales()
        {
            salesMananger = new SalesMananger(libraryManager);
            salesMananger.Show();
            salesMananger.Sell(gamer, 1);
            salesMananger.Sell(gamer, 5);
        }

        static void Campaign()
        {
            campaignManager = new CampaignManager(gameLibrary, 30);
            campaignManager.Add();
            campaignManager.Update(50);
            
        }
        
    }
}
