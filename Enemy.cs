using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Enemy
    {
        public int health;

        public void TakeDamage(int damage)
        {
            health -= damage;
        }
    }
}
