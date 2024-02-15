using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgGame
{
    internal class DiamondSword
    {
        static string name = "Espada de Diamante";
        static int price = 100;
        static int damage = 40;

        public static string Name { get => name; set => name = value; }
        public static int Price { get => price; set => price = value; }
        public static int Damage { get => damage; set => damage = value; }
    }
}
