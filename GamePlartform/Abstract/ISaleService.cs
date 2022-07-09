using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePlartform.Entities;

namespace GamePlartform.Abstract
{
    internal interface ISaleService
    {
        void Record(Player player, Game game, Compaigns compaigns);
        void Record(Player player, Game game);
    }
}
