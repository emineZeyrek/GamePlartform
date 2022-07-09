using GamePlartform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlartform.Abstract
{
    internal class GameManager
    {

        public void Add(Game game)
        {
            Console.WriteLine("Game successfully added! :" + " " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game successfully deleted! :" + " " + game.GameName);
        }

    }
}
