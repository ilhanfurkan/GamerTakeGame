using GamerTakeGame.Abstract;
using GamerTakeGame.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerTakeGame.Concrete
{
    internal class GameSiteSalesManager : IGameSalesService
    {
        public void Sale(Gamers gamer, Games game)
        {
            Console.WriteLine(game.GameName + " Oyununun, " +game.GamePrice.ToString("0.##") + " Tl'lik ödeme işlemi tamamlanmış ve " + gamer.Name + " " + gamer.LastName + " kullanıcısının kütüphanesine eklenmiştir. ");
        }
        //public void Sale(Campaign campaign, Gamers gamer, Games game)
        //{
        //    double temporary = 0;
        //    double result = 0;
        //    temporary = game.GamePrice;
        //    result = game.GamePrice * ((100 - campaign.Discount) / 100);
        //    game.GamePrice = result;
        //    Console.WriteLine(game.GameName + ", " + temporary + " Yerine geçici süreliğine sadece " + game.GamePrice + " Tl.");
        //    Console.WriteLine(game.GameName + " Oyunun, " + game.GamePrice + " Tl'lik ödeme işlemi tamamlanmış ve " + gamer.Name + " " + gamer.LastName + " kullanıcısının kütüphanesine eklenmiştir. ");
        //}
    }
}
