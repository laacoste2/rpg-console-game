using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRpgGame
{
    internal interface IMonster
    {
        void Attack(Warrior character);
    }
}
