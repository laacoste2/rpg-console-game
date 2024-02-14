using System;
using System.ComponentModel.Design;

namespace ConsoleRpgGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character(100, 20); // vida dano
            Monster monster = new Monster(100, 5, 100); //vida dano gold

            while (true)
            {
                Console.WriteLine("Bem vindo ao 'RPG Game'");
                Console.WriteLine("A classe do seu personagem é: " + character.name);
                Console.WriteLine("Digite [P] para prosseguir à aventura | Digite outra coisa para sair");
                string prosseguirOuNao = Console.ReadLine();
                
                if(prosseguirOuNao != "P")
                {
                    Console.WriteLine("Saindo do 'RPG Game'");
                    Console.ReadLine();
                    return;
                }

                Console.Clear();
                Console.WriteLine("Seu personagem encontrou um Monstro!");
                Console.WriteLine("[A]tacar | [I]nventario");
                string action = Console.ReadLine();

                if (action == "A")
                {
                    int x = 1;
                    while (character.Health > 1 && x == 1)
                    {
                        if(character.Health < 1)
                        {
                            Console.WriteLine("O seu personagem morreu... Voltando ao ínicio do 'RPG Game'");
                            Console.ReadLine();
                        }else if(monster.Health < 1)
                        {
                            Console.WriteLine("O monstro morreu...");
                            Console.WriteLine("Seu personagem ganhou " + monster.Gold + "de gold");
                            character.Gold = monster.Gold;

                            Console.WriteLine("Seu personagem tem " + character.Gold + " de ouro");
                            Console.WriteLine("Prosseguindo na aventura...");

                            Console.ReadLine();
                            x = 1;
                            break;
                        }

                        Console.WriteLine("[A]tacar Novamente | [F]ugir");
                        string actionTwo = Console.ReadLine();

                        if (actionTwo == "A")
                        {
                            Console.Clear();
                            character.Attack(monster);
                            monster.Attack(character);
                            x = 1;
                        }
                        else if (actionTwo == "F")
                        {
                            Random rand = new Random();
                            int sucessfulyOrNot = rand.Next(1, 3);
                            if (sucessfulyOrNot == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Seu personagem conseguiu fugir com exito" + sucessfulyOrNot);
                                x = 0;

                                Console.ReadLine();

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Seu personagem não conseguiu fugir" + sucessfulyOrNot);

                                Console.ReadLine();
                                monster.Attack(character);

                            }
                        }
                    }
                }

                Console.WriteLine("Seu personagem prosseguiu na aventura...");
                Console.ReadLine();
                Console.WriteLine("...");
                Console.ReadLine();
                Console.WriteLine("...");
                Console.ReadLine();
                Console.WriteLine("Após alguns minutos de caminhada, seu personagem encontrou uma rua levando a dois caminhos diferentes");
                Console.WriteLine("No caminho à esquerda, há uma placa escrito: Loja Adiante!");
                Console.WriteLine("No caminho à direita, há uma placa escrito: Dungeon Adiante!");
                Console.WriteLine("[E] para ir à esquerda | [D] para ir à direita");
                string actionThree = Console.ReadLine();

                if(actionThree == "E")
                {
                    Console.WriteLine("Seu personagem começa a se mover para o caminho à esquerda");
                    Console.ReadLine();
                    Console.WriteLine("...");
                    Console.ReadLine();
                    Console.WriteLine("Depois de uma longa caminhada, seu personagem encontra um ser que se parecia com um anão");
                    Console.WriteLine("Este anão estava dentro de um edíficio com uma placa escrito: LOJA AQUI!!");
                    Console.ReadLine();
                    Console.WriteLine("Após notar sua presença, o anão começa a falar alto:");
                    Console.WriteLine("- Finalmente um cliente! Venha aqui meu jovem, em minha loja tenho os melhores equipamentos");
                    Console.ReadLine();
                    Console.WriteLine("Seu personagem chega perto e o anão começa a mostra-lo sua loja: ");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Espada de Ouro - Preço: 25 de gold - Dano: 10");
                    Console.WriteLine("Espada de Diamante - Preço: 100 de gold - Dano: 40");
                    Console.ReadLine();
                    Console.WriteLine("Qual desses você vai querer, meu jovem?");
                    Console.WriteLine("[O] para comprar Espada de Ouro");
                    Console.WriteLine("[D] para comprar Espada de Diamante");
                    string actionFour = Console.ReadLine();

                    if (actionFour == "O")
                    {
                        Console.WriteLine("Seu personagem comprou uma Espada de Ouro por 25 de gold");
                        character.Gold -= 25;
                        Console.WriteLine("Seu personagem possui: " + character.Gold + " de gold");
                        Console.ReadLine();
                    }
                    else if (actionFour == "D")
                    {
                        Console.WriteLine("Seu personagem comprou uma Espada de Diamante por 100 de gold");
                        character.Gold -= 100;
                        Console.WriteLine("Seu personagem possui: " + character.Gold + " de gold");
                        Console.ReadLine();

                    }

                    Console.Clear();
                    Console.WriteLine("Após visitar a loja do anão, seu personagem segue pelo caminho adiante");

                }
                else if(actionThree == "D")
                {
                    Console.WriteLine("Seu personagem começa a se mover para o caminho à direita");
                }

            }


        }
    }
}
