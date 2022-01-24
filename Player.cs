using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Player : GameCharacter //player is a game character
    {
        public int lives;
        public void ShowStats()
        {
            Console.WriteLine("Health: " + health);
        }
    }
}
