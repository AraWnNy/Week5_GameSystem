using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    interface IGameLibraryService
    {
        void Add(Game game);
        void Delete(Game game);
        void Show();
        Game GetGame(int ID);

    }
}
