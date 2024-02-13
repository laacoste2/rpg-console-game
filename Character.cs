using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleRpgGame
{
    internal class Character
    {
        private int _health;
        private int _strenght;

        public int Health { get => _health; set => _health = value; }
        public int Strenght { get => _strenght; set => _strenght = value; }

        public Character(int health, int strenght)
        {
            _health = health;
            _strenght = strenght;
        }


        public void Attack(int strenght, int monster)
        {

        }

    }
}
