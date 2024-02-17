using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgGame
{
    internal class Spider : IMonster
    {
        private int _health;
        private int _strenght;
        private int _gold;

        public int Health { get => _health; set => _health = value; }
        public int Strenght { get => _strenght; set => _strenght = value; }
        public int Gold { get => _gold; set => _gold = value; }

        public Spider(int health, int strenght, int gold)
        {
            _health = health;
            _strenght = strenght;
            _gold = gold;
        }


        public void Attack(Warrior character) //Monster and Character Object
        {
            Random rand = new Random();

            int randomNumber = rand.Next(1, 6); //6-1 

            if (randomNumber == 3)
            {
                character.Health -= Strenght * 2;

                Console.WriteLine("A aranha deu um acerto crítico de " + (Strenght * 2) + " de dano");
                Console.WriteLine("Seu personagem ficou com " + character.Health + " de vida");

            }
            else
            {
                character.Health -= Strenght;

                Console.WriteLine("A aranha deu " + Strenght + " de dano");
                Console.WriteLine("Seu personagem ficou com " + character.Health + " de vida");

            }

        }
    }
}
