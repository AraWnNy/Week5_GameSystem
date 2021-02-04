using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    class GamerManager : IGamerService
    {
        private IValidationService _validationService;
        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }
        public void Add(Gamer gamer)
        {
            if (_validationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt Oluşturuldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt oluşturulamadı.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void ShowGameLibrary(Gamer gamer)
        {
            foreach (Game game in gamer.UserGames)
            {
                Console.WriteLine("*********\nOyun ID = {0}\nOyun İsmi = {1}\n*********", game.GameID, game.GameName);
            }

            Console.WriteLine("\nKullanıcının kütüphanesinde {0} oyun var", gamer.UserGames.Count);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
