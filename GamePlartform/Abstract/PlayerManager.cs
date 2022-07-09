using GamePlartform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePlartform.Abstract;


namespace GamePlartform.Abstract
{
    internal class PlayerManager
    {
        public  void Record(Player player)
        {

            Console.WriteLine("Player information recorded! " + " " + player.PlayerId + " " + player.FirstName);

        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player information deleted! : " + " " + player.PlayerId + " " + player.FirstName);
        }
        public void Update(Player player)
        {
            Console.WriteLine("Player information updated! " + " " + player.PlayerId + " " + player.FirstName);
        }
    }



}
