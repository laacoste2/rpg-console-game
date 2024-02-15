using System;
using System.ComponentModel.Design;

namespace ConsoleRpgGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior(100, 20); // vida dano
            Spider spider = new Spider(100, 5, 100); //vida dano gold

            while (true)
            {
                Console.WriteLine("Bem vindo ao 'RPG Game'");
                Console.WriteLine("A classe do seu personagem é: " + warrior.name);
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
                Console.WriteLine("[A]tacar | [I]nventario"); //Inventario ainda não foi implementado
                string action = Console.ReadLine();

                if (action == "A")
                {
                    int x = 1;
                    while (warrior.Health > 1 && x == 1)
                    {
                        if(warrior.Health < 1)
                        {
                            Console.WriteLine("O seu personagem morreu... Voltando ao ínicio do 'RPG Game'");
                            Console.ReadLine();
                        }else if(spider.Health < 1)
                        {
                            Console.Clear();
                            Console.WriteLine("\nO monstro morreu...");
                            Console.WriteLine("\nSeu personagem ganhou " + spider.Gold + " de gold");
                            warrior.Gold = spider.Gold;

                            Console.WriteLine("Seu personagem tem " + warrior.Gold + " de ouro");
                            Console.WriteLine("Prosseguindo na aventura...");

                            Console.ReadLine();
                            Console.Clear();
                            x = 1;
                            break;
                        }

                        Console.WriteLine("[A]tacar Novamente | [F]ugir");
                        string actionTwo = Console.ReadLine();

                        if (actionTwo == "A")
                        {
                            Console.Clear();
                            warrior.Attack(spider);
                            spider.Attack(warrior);
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
                                spider.Attack(warrior);
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
                        Console.WriteLine("Seu personagem comprou uma Espada de Ouro por " + GoldenSword.Name + " de gold");
                        warrior.Gold -= GoldenSword.Price;
                        warrior.Strenght += GoldenSword.Damage;
                        Console.WriteLine("Seu personagem possui: " + warrior.Gold + " de gold");
                        Console.ReadLine();
                    }
                    else if (actionFour == "D")
                    {
                        Console.WriteLine("Seu personagem comprou uma Espada de Diamante por " + DiamondSword.Name + " 100 de gold");
                        warrior.Gold -= DiamondSword.Price;
                        Console.WriteLine("Seu personagem possui: " + warrior.Gold + " de gold");
                        Console.ReadLine();

                    }

                    Console.Clear();
                    Console.WriteLine("Após visitar a loja do anão, seu personagem segue pelo caminho adiante");

                }
                else if(actionThree == "D")
                {
                    Console.WriteLine("Seu personagem começa a se mover para o caminho à direita");
                    Console.ReadLine();
                    Console.WriteLine("...");
                    Console.WriteLine("Ao longo do caminho, seu personagem percebe a decadência da rua em que está andando");
                    Console.WriteLine("Quanto mais você anda, a rua vai ficando mas decadente... Como se ninguem tivesse ido fazer a manutenção dela");
                    Console.WriteLine("...");
                    Console.ReadLine();
                    Console.WriteLine("Após mais alguns minutos de caminhada, você chega ao local que a placa de anteriormente se referia");
                    Console.WriteLine("O local possuia um espaço como se fosse a entrada");
                    Console.WriteLine("Você segue adiante e desce ao que parecia uma entrada de caverna");
                    Console.WriteLine("Ao chegar ao local, você percebe uma outra entrada, dessa vez com uma porta");
                    Console.WriteLine("Acima dessa porta há uma placa escrito: 'Perigo!! Dungeon Perigo!!'");
                    Console.ReadLine();
                    Console.WriteLine("...");
                    Console.ReadLine();
                    Console.WriteLine("Entrando...");
                    Console.WriteLine("...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Logo após abrir a porta, você percebe dois monstros de costas, como se estivessem de guarda");

                    Console.WriteLine("[A]proveitar a oportunidade e apunhalá-los pelas costas (CRÍTICO GARANTIDO) | [N]ão fazer nada");
                    string actionFive = Console.ReadLine();

                    if (actionFive == "A")
                    {
                        Console.Clear();
                        Console.WriteLine("Você corre até as costas do monstro da esquerda e enfia a espada em seu pescoço");
                        Console.WriteLine("\n- Monstro 1 morreu - ");
                        Console.WriteLine("\nApós matar o primeiro monstro, o outro monstro que está localizado à sua direita percebe sua presença");
                        Console.WriteLine("Mas, rapidamente você retira sua espada do pescoço do monstro e a arremessa direto na testa do segundo monstro");
                        Console.WriteLine("\n- Monstro 2 morreu - ");
                    }else if(actionFive == "N")
                    {
                        Console.WriteLine("Como você não fez nada, os monstros perceberam sua presença");
                        Console.WriteLine("Após isso, você é obrigado a iniciar um combate com os dois ao mesmo tempo");

                        Console.WriteLine("[A]tacar");
                        string actionSix = Console.ReadLine();

                        Spider spiderTwo = new Spider(100, 20, 115);
                        Spider spiderThree = new Spider(100, 20, 115);

                        if (actionSix == "A")
                        {
                            int x = 1;
                            while (warrior.Health > 1 && x == 1)
                            {
                                if (warrior.Health < 1)
                                {
                                    Console.WriteLine("O seu personagem morreu... Voltando ao ínicio do 'RPG Game'");
                                    Console.ReadLine();
                                }
                                else if (spider.Health < 1)
                                {
                                    Console.WriteLine("O monstro morreu...");
                                    Console.WriteLine("Seu personagem ganhou " + spider.Gold + "de gold");
                                    Console.WriteLine("Seu personagem ganhou " + spider.Gold + "de gold");

                                    warrior.Gold = spider.Gold + spider.Gold;

                                    Console.WriteLine("Você tem " + warrior.Gold + " de gold");

                                    Console.ReadLine();
                                    x = 1;
                                    break;
                                }

                                Console.WriteLine("[A]tacar Novamente | [F]ugir");
                                string actionTwo = Console.ReadLine();

                                if (actionTwo == "A")
                                {
                                    Console.Clear();
                                    warrior.Attack(spider);
                                    spiderTwo.Attack(warrior);
                                    spiderThree.Attack(warrior);
                                    x = 1;
                                }
                                else if (actionTwo == "F")
                                {
                                    Console.WriteLine("Não é possivel fugir no momento");
                                }
                            }
                        }


                    }
                }

                //aq

            }


        }
    }
}
