using GamerTakeGame.Abstract;
using GamerTakeGame.Adapter;
using GamerTakeGame.Concrete;
using GamerTakeGame.Entities;

namespace GamerTakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamers gamer = new Gamers() { Id = 1, Name = "Furkan", LastName = "İlhan", NationalId = "55286315004", DateofBirth = new DateTime(1999, 10, 03) };

            BaseGamerManager gameSiteGamerManager = new GameSiteGamerManager(new MernisService());
            //gameSiteGamerManager.Save(gamer);
            //gameSiteGamerManager.Delete(gamer);


            Campaign campaign = new Campaign() { Id=1,CampaignName="Yıl Sonu Kampanyası",Discount=20};
            Campaign campaign1 = new Campaign() { Id=1,CampaignName="Yıl Sonu Kampanyası",Discount=30};

            Games game = new Games(){ Id = 1,GameName = "Call Of Duty",GamePrice = 220.50};
            Games game1 = new Games() { Id = 2, GameName = "Rocket League", GamePrice = 38.30 };
            Games game2 = new Games() { Id = 1, GameName = "Futbol Manager 2022", GamePrice = 399.99 };


            GameSiteCampaignManager gameSiteCampaignManager = new GameSiteCampaignManager();
            GameSiteSalesManager gameSiteSalesManager = new GameSiteSalesManager();


            gameSiteCampaignManager.CInput(campaign, game1);
            gameSiteSalesManager.Sale(gamer, game1);

            gameSiteCampaignManager.CInput(campaign, game);
            gameSiteSalesManager.Sale(gamer, game);

            gameSiteCampaignManager.CRemove(campaign, game);
            gameSiteSalesManager.Sale(gamer, game);

            gameSiteCampaignManager.CUpdate(campaign, 30, game);
            gameSiteSalesManager.Sale(gamer, game);

            

            Console.ReadLine();
        }
    }
}