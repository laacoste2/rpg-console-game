using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgGame
{
    internal class Warrior
    {
        public string name = "Warrior";
        private int _health;
        private int _strenght;
        private int _gold;

        public int Health { get => _health; set => _health = value; }
        public int Strenght { get => _strenght; set => _strenght = value; }
        public int Gold { get => _gold; set => _gold = value; }

        public Warrior(int health, int strenght)
        {
            _health = health;
            _strenght = strenght;
        }


        public void Attack(Spider monster) //Monster and Character Object
        {
            Random rand = new Random();

            int randomNumber = rand.Next(1, 5); //5-1 

            if (randomNumber == 3)
            {
                monster.Health -= Strenght * 2;

                Console.WriteLine("Seu acerto crítico deu " + (Strenght * 2) + " de dano");
                Console.WriteLine("O monstro ficou com " + monster.Health + " de vida");

            }
            else
            {
                monster.Health -= Strenght;

                Console.WriteLine("Você deu " + Strenght + " de dano");
                Console.WriteLine("O monstro ficou com " + monster.Health + " de vida");

            }

        }
    }
}
