using System;

namespace ConsoleRpgGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character(100, 20);
            Monster monster = new Monster(100, 20);

            //while (true)
            {
                int x = 1;
                while(character.Health > 1 && x == 1)
                {
                    monster.Attack(character);
                    Console.WriteLine("[A]tacar Novamente | [F]ugir");
                    string action = Console.ReadLine();

                    if (action == "F")
                    {
                        Random rand = new Random();
                        int sucessfulyOrNot = rand.Next(1, 3);
                        if (sucessfulyOrNot == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Você conseguiu fugir com exito" + sucessfulyOrNot);
                            x = 0;

                            Console.ReadLine();

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Você não conseguiu fugir" + sucessfulyOrNot);

                            Console.ReadLine();

                        }
                    }
                }

                Console.WriteLine("O monstro morreu");
            }
            
            
        }
    }
}
