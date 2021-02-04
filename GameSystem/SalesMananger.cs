using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    class SalesMananger : ISalesService
    {
        private IGameLibraryService _service;

        public SalesMananger(IGameLibraryService service)
        {
            _service = service;
        }
        
        public void Sell(Gamer gamer, int GameId)
        {
            Game tempGame = _service.GetGame(GameId);
            if (tempGame != null)
            {
                gamer.UserGames.Add(tempGame);
            }
            else
            {
                Console.WriteLine("Girilen ID numarasında bir oyun bulunmamıştır. Lütfen yeniden deneyiniz.");
            }
        }
        public void Show()
        {
            _service.Show();
        }
    }
}
