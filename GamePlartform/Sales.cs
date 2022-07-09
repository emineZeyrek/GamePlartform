using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlartform
{
    internal class Sales
    {
        public int SalesId { get; set; }
        public int GameId { get; set; }
        public int PlayerId { get; set; }
        public string GameName { get; set; }
        public int CampaignId { get; set; }
    }
}
