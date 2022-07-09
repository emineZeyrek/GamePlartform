using GamePlartform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlartform.Abstract
{
    internal class CampaignService
    {

        public void Entry(Campaigns offers)
        {
            Console.WriteLine("Campaign login successfu");

        }
        public void Delete(Campaigns offers)
        {
            Console.WriteLine("Campaign information deleted");

        }
        public void Update(Campaigns offers)
        {
            Console.WriteLine("Campaign information updated");

        }


    }
}
