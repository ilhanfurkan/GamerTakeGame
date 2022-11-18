using GamerTakeGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerTakeGame.Abstract
{
    internal abstract class BaseGamerManager : IGamerService
    {
        public virtual void Delete(Gamers gamer)
        {
            Console.WriteLine("Delete from Database : " + gamer.Name + " " + gamer.LastName);
        }

        public virtual void Save(Gamers gamer)
        {
            Console.WriteLine("Save to Database : " + gamer.Name + " " + gamer.LastName);
        }

        public virtual void Update(Gamers gamer)
        {
            Console.WriteLine("Update from Database : " + gamer.Name + " " + gamer.LastName);
        }
    }
}
