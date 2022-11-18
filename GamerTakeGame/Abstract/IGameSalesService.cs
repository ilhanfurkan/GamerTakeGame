using GamerTakeGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerTakeGame.Abstract
{
    public interface IGameSalesService
    {
        void Sale(Gamers gamer,Games game);
    }
}
