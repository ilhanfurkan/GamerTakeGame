using GamerTakeGame.Abstract;
using GamerTakeGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerTakeGame.Concrete
{
    internal class GameSiteGamerManager : BaseGamerManager
    {
        //public override void Delete(Gamers gamer)
        //{
        //    Console.WriteLine("Kayıt Silindi.");
        //}
        private IGamerCheckService _gamerCheckService;

        public GameSiteGamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamers gamer)
        {
            if (_gamerCheckService.CheckGamerOnMernis(gamer) )
            {
                base.Save(gamer);
            }
            else
            {
                Console.WriteLine("Kayıt Gerçekleştirilemedi. Lütfen ");
            }
            
        }

        //public override void Update(Gamers gamer)
        //{
        //    Console.WriteLine("Bilgiler Güncellendi");
        //}
    }
}
