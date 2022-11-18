using GamerTakeGame.Abstract;
using GamerTakeGame.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GamerTakeGame.Concrete
{
    internal class GameSiteCampaignManager : ICampaignService
    {
        double temporaryPrice = 0;
        double result = 0;
        public void CInput(Campaign campaign, Games game)
        {
            temporaryPrice = game.GamePrice;
            result = game.GamePrice * ((100 - campaign.Discount) / 100);
            game.GamePrice = result;
            Console.WriteLine(game.GameName + ", " + temporaryPrice + " Yerine geçici süreliğine sadece " + game.GamePrice + " Tl.");
        }

        public void CRemove(Campaign campaign,Games game)
        {
            temporaryPrice = game.GamePrice;
            result = game.GamePrice * ((100 - campaign.Discount) / 100);
            game.GamePrice = result;
            Console.WriteLine(game.GameName + " Oyununun indirimi kaldırılmıştır.");
        }

        public void CUpdate(Campaign campaign,double newcampign,Games game)
        {
            temporaryPrice = game.GamePrice;
            result = game.GamePrice * ((100 - campaign.Discount) / 100);
            game.GamePrice = result;
            Console.WriteLine("Kampanya %"+campaign.Discount+" olarak güncellenmiştir.");
        }
    }
}
