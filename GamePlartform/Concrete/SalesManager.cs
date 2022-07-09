using GamePlartform.Abstract;
using GamePlartform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePlartform.Abstract;
using GamePlartform.Entities;
using GamePlartform.Concrete;

namespace GamePlartform.Concrete
{
    internal class SalesManager : ISalesService
    {
        public void Record(Player player, Game game, Campaigns campaigns)
        {
            Console.WriteLine("Discount used in game sale" + " " + game.GameName+ " "+ player.PlayerId+ " "+ campaigns.CampaignName);
        }

        public void Record(Player player, Game game)
        {
            Console.WriteLine("The sale transaction has been successfully saved" + " " + game.GameName + " " + player.PlayerId);
        }

       

    }
}

