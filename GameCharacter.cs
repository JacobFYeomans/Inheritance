using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class GameCharacter //cannot create instance of abstract classes
    {
        public int health;

        public void TakeDamage(int damage)
        {
            health -= damage;
        }
    }
}
