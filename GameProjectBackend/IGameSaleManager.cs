using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackend
{
    public interface IGameSaleManager
    {
       void Sale(User user, Game game, Campaign campaign);

    }
}
