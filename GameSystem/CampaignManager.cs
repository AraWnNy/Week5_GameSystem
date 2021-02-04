using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    class CampaignManager : ICampaignService
    {
        private Library _library;
        private long _campaignPercentage;
        public CampaignManager(Library library, long campaignPercentage)
        {
            _library = library;
            _campaignPercentage = campaignPercentage;
        }

        public void Add()
        {
            foreach (Game game in _library.Games)
            {
                game.discountPrice = game.Price;
                game.Price = game.Price + ((game.Price*_campaignPercentage)/100);
            }
        }

        public void Delete()
        {
            foreach (Game game in _library.Games)
            {
                game.Price = game.discountPrice;
            }
        }

        public void Update(long campaignPercentage)
        {
            Delete(); //Fiyatı kampanyasız haline getirir
            _campaignPercentage = campaignPercentage;
            Add(); //Yeni oran üzerinden kampanyayı uygular
        }
    }
}
