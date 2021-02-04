using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystem
{
    interface ISalesService
    {
        void Sell(Gamer gamer, int GameId);
        void Show();
    }
}
