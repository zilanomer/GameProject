using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackend
{
    internal class GameSaleManager : IGameSaleManager
    {
        public void Sale(User user, Game game, Campaign campaign)
        {
            double saleprice = (game.Price) - ((game.Price * campaign.DiscountRate) / 100);

            Console.WriteLine(game.GameName + " "+  saleprice + "TL ye satıldı.");
        }
    }
}
