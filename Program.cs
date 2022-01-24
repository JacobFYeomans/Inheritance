using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance: ");
            Console.WriteLine();

            Player player = new Player();
            Enemy enemy = new Enemy();

            //player.health = 100;
            player.lives = 3;
            //Console.WriteLine(player.health);
            player.TakeDamage(10);
            //Console.WriteLine(player.health);

            //enemy.health = 50;
            //Console.WriteLine(enemy.health);
            enemy.TakeDamage(15);
            //Console.WriteLine(enemy.health);
            

            Console.ReadKey(true);
        }
    }
}
