using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgGame
{
    internal class Monster
    {
        private int _health;
        private int _strenght;

        public int Health { get => _health; set => _health = value; }
        public int Strenght { get => _strenght; set => _strenght = value; }

        public Monster(int health, int strenght)
        {
            _health = health;
            _strenght = strenght;
        }


        public void Attack(Character character) //Monster and Character Object
        {
            Random rand = new Random();

            int randomNumber = rand.Next(1, 6); //6-1 

            if(randomNumber == 3) {
                character.Health -= Strenght * 2;

                Console.Clear();
                Console.WriteLine("Seu acerto crítico deu " + (Strenght*2) + " de dano");
                Console.WriteLine("O personagem ficou com " + character.Health + " de vida");
                
            }
            else
            {
                character.Health -= Strenght;

                Console.Clear();
                Console.WriteLine("Você deu " + Strenght + " de dano");
                Console.WriteLine("O personagem ficou com " + character.Health + " de vida");

            }

        }
    }
}
