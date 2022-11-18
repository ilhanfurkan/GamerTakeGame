using GamerTakeGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerTakeGame.Abstract
{
    public interface IGamerService
    {
        void Save(Gamers gamer);
        void Delete(Gamers gamer);
        void Update(Gamers gamer);
    }
}
