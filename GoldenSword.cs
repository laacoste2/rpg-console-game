using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgGame
{
    internal class GoldenSword
    {
        static string name = "Espada de Ouro";
        static int price = 25;
        static int damage = 10;

        public static string Name { get => name; set => name = value; }
        public static int Price { get => price; set => price = value; }
        public static int Damage { get => damage; set => damage = value; }
    }
}
