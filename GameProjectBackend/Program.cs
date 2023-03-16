using System;

namespace GameProjectBackend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();

            user1.FirstName = "Zilan";
            user1.LastName = "Ömer";
            user1.DateOfBirth = new DateTime(2000, 06, 06);
            user1.NationalityId = "1111111111";
            UserManager userManager = new UserManager();
            //userManager.Add(user1);


            Campaign campaign = new Campaign();
            campaign.CampaignName = "Ayın Son İndirimi";
            campaign.DeadLine = new DateTime(2023, 03, 16);
            campaign.DiscountRate = 50;
            CampaignManager campaignManager = new CampaignManager();
           // campaignManager.Add(campaign);


            Game game = new Game();
            game.GameName = "Valorant";
            game.Price = 2000;

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(user1, game, campaign);

            

        }
    }
}
