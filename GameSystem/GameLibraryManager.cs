using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    class GameLibraryManager : IGameLibraryService
    {
        private Library _gameLibrary;
        public GameLibraryManager(Library gameLibrary)
        {
            _gameLibrary = gameLibrary;
        }
        public void Add(Game game)
        {
            _gameLibrary.Games.Add(game);
        }

        public void Delete(Game game)
        {
            _gameLibrary.Games.Remove(game);
        }

        public void Show()
        {
            foreach (Game game in _gameLibrary.Games)
            {
                Console.WriteLine("*********\nOyun ID = {0}\nOyun İsmi = {1}\nOyun Fiyatı = {2}\n*********",game.GameID, game.GameName, game.Price);
            }
        }

        public Game GetGame(int ID)
        {
            Game tempGame = null;
            foreach (Game game in _gameLibrary.Games)
            {
                if (game.GameID.Equals(ID))
                {
                    tempGame = game;
                }
            }
            return tempGame;
        }
    }
}
