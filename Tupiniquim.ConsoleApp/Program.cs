using System;

namespace Tupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           //Declaração de variáveis

            int x_robo1, y_robo1, x_area, y_area;
            int x_robo2, y_robo2=0;
            char direcao, direcao2, opcao;
            string comando,comando2;


            //Apresentação do Programa

            interfaceRobo();
            Console.Clear();

       
            Console.ForegroundColor = ConsoleColor.White;

            //Atribuição de valores do plano

            do {
                Console.WriteLine("Digite o valor da cordenada X do canto superior direito:");
                x_area = System.Convert.ToInt32(Console.ReadLine());

                if(x_area < 0)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Insira um valor válido");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }while (x_area<0);
          
            do
            {

                Console.WriteLine("Digite o valor da cordenada Y do canto superior direito:");
                y_area = System.Convert.ToInt32(Console.ReadLine());

                if(y_area < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insira um valor válido");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Clear();
            }while (y_area<0);



            //Atribuição de valores da posição inicial do robô 1 e robô 2

            do
            {

                do
                {
                    Console.WriteLine("Digite o valor da cordenada X inicial do robô 1:");

                    x_robo1 = System.Convert.ToInt32(Console.ReadLine());
                    if (x_robo1 > x_area)
                    {
                        Console.WriteLine("O valor está fora do limite registrado, tente novamente");
                    }

                } while (x_robo1 > x_area);


                do
                {

                    Console.WriteLine("Digite o valor da cordenada Y inicial do robô 1:");
                    y_robo1 = System.Convert.ToInt32(Console.ReadLine());
                    if (y_robo1 > y_area)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor está fora do limite registrado, tente novamente");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } while (y_robo1 > y_area);

                Console.Clear();

                //Atribuição da direção inicial do robô

                do
                {
                    Console.WriteLine("Digite a direção inicial do robô:(n/s/l/o)");
                    direcao = System.Convert.ToChar(Console.ReadLine());

                    if (direcao != 'n' && direcao != 's' && direcao != 'l' && direcao != 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Direção inválida, tente novamente..");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        break;
                    }

                } while (direcao != 'n' && direcao != 's' && direcao != 'l' && direcao != 'o');


                Console.Clear();


                //Atribuição dos comandos que serão lidos pelo robô


                Console.WriteLine("Digite os comandos que serão transmitidos ao robô:");
                comando = System.Convert.ToString(Console.ReadLine());


                Console.Clear();

               


                char[] instrucoes = comando.ToCharArray();


                //Cadeias de if para a movimentação

                for (int i = 0; i < instrucoes.Length; i++)
                {
                    Console.WriteLine(instrucoes[i]);

                    if (instrucoes[i] == 'm')
                    {

                        switch (direcao)
                        {
                            case 'n':
                                if ((y_robo1 + 1) > y_area)
                                {
                                    break;
                                }
                                else
                                {
                                    y_robo1 = y_robo1 + 1;
                                    break;
                                }



                            case 's':
                                if ((y_robo1 - 1) < y_area)
                                {
                                    break;
                                }
                                else
                                {
                                    y_robo1 = y_robo1 - 1;
                                    break;
                                }



                            case 'l':
                                if (x_robo1 + 1 > x_area)
                                {
                                    break;
                                }
                                else
                                {
                                    x_robo1 = x_robo1 + 1;
                                    break;

                                }



                            case 'o':
                                if (x_robo1 - 1 < x_area)
                                {
                                    break;
                                }
                                else
                                {
                                    x_robo1 = x_robo1 - 1;
                                    break;
                                }

                            default:
                                break;
                        }
                    }

                    if (instrucoes[i] == 'e')
                    {
                        switch (direcao)
                        {
                            case 'n':
                                direcao = 'o';
                                break;
                            case 's':
                                direcao = 'l';
                                break;
                            case 'l':
                                direcao = 'n';
                                break;
                            case 'o':
                                direcao = 's';
                                break;


                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Comando Inválido, reinicie o sistema..");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                    }

                    if (instrucoes[i] == 'd')
                    {
                        switch (direcao)
                        {
                            case 'n':
                                direcao = 'l';
                                break;
                            case 's':
                                direcao = 'o';
                                break;
                            case 'l':
                                direcao = 's';
                                break;
                            case 'o':
                                direcao = 'n';
                                break;


                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Comando Inválido, reinicie o sistema..");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                    }



                }

                //Iniciando o segundo Robô

                
                 
                do
                {
                    Console.WriteLine("Digite o valor da cordenada X inicial do robô 2:");

                    x_robo2 = System.Convert.ToInt32(Console.ReadLine());
                    if (x_robo2 > x_area)
                    {
                        Console.WriteLine("O valor está fora do limite registrado, tente novamente");
                    }

                } while (x_robo2 > x_area);


                do
                {

                    Console.WriteLine("Digite o valor da cordenada Y inicial do robô 2:");
                    y_robo1 = System.Convert.ToInt32(Console.ReadLine());
                    if (y_robo2 > y_area)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("O valor está fora do limite registrado, tente novamente");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } while (y_robo2 > y_area);



                //Atribuição da direção inicial do robô 2

                do
                {
                    Console.WriteLine("Digite a direção inicial do robô:(n/s/l/o)");
                    direcao2 = System.Convert.ToChar(Console.ReadLine());

                    if (direcao2 != 'n' && direcao2 != 's' && direcao2 != 'l' && direcao2 != 'o')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Direção inválida, tente novamente..");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        break;
                    }

                } while (direcao2 != 'n' && direcao2 != 's' && direcao2 != 'l' && direcao2 != 'o');

  
                Console.Clear();


                //Atribuição dos comandos que serão lidos pelo segundo robô


                Console.WriteLine("Digite os comandos que serão transmitidos ao robô:");
                comando2 = System.Convert.ToString(Console.ReadLine());


                Console.Clear();


              //Atribuição de instruções que serão lido pelo segundo robô

                char[] instrucoes2 = comando2.ToCharArray();


                //Cadeias de if para a movimentação do segundo robô
                for (int i = 0; i < instrucoes2.Length; i++)
                {
                    Console.WriteLine(instrucoes2[i]);

                    if (instrucoes2[i] == 'm')
                    {

                        switch (direcao2)
                        {
                            case 'n':
                                if ((y_robo2 + 1) > y_area)
                                {
                                    break;
                                }
                                else
                                {
                                    y_robo2 = y_robo2 + 1;
                                    break;
                                }



                            case 's':
                                if ((y_robo2 - 1) > y_area)
                                {
                                    break;
                                }
                                else
                                {
                                    y_robo2 = y_robo2 - 1;
                                    break;
                                }



                            case 'l':
                                if (x_robo2 + 1 > x_area)
                                {
                                    break;
                                }
                                else
                                {
                                    x_robo2 = x_robo2 + 1;
                                    break;

                                }



                            case 'o':
                                if (x_robo2 - 1 > x_area)
                                {
                                    break;
                                }
                                else
                                {
                                    x_robo2 = x_robo2 - 1;
                                    break;
                                }

                            default:
                                break;
                        }
                    }

                    if (instrucoes2[i] == 'e')
                    {
                        switch (direcao2)
                        {
                            case 'n':
                                direcao2 = 'o';
                                break;
                            case 's':
                                direcao2 = 'l';
                                break;
                            case 'l':
                                direcao2 = 'n';
                                break;
                            case 'o':
                                direcao2 = 's';
                                break;


                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Comando Inválido, reinicie o sistema..");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                    }

                    if (instrucoes2[i] == 'd')
                    {
                        switch (direcao2)
                        {
                            case 'n':
                                direcao2 = 'l';
                                break;
                            case 's':
                                direcao2 = 'o';
                                break;
                            case 'l':
                                direcao2 = 's';
                                break;
                            case 'o':
                                direcao2 = 'n';
                                break;


                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Comando Inválido, reinicie o sistema..");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                    }



                }


                Console.Clear();

                

                //Mostrando a posição final do robô 1 e robô 2

                

                Console.WriteLine("Posição Final do Robô 1 e do Robô 2 respectivamente:");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine(x_robo1 + " " + y_robo1 + " " + direcao);
                Console.WriteLine(x_robo2 + " " + y_robo2 + " " + direcao);
                Console.ForegroundColor = ConsoleColor.White;

                Console.ReadKey();


                //Verificando se será necessário mais uma varredura

                do
                {

                    Console.Clear();
                    Console.WriteLine("Deseja realizar mais uma varredura? (s/n)");
                    opcao = System.Convert.ToChar(Console.ReadLine());

                    if (opcao != 's' && opcao != 'n')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Comando inválido, digite novamente..");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        break;
                    }

                } while (opcao != 's' && opcao != 'n');


            } while (opcao == 's');


        }

        public static void interfaceRobo(){

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("//---------------------------------------\\");
            Console.WriteLine("|          Interface de Controle         |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|             Comandos Gerais:           |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|           m = mover pra frente         |");
            Console.WriteLine("|    e = mover direcão para a esquerda   |");
            Console.WriteLine("|    d = mover direcão para a esquerda   |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|        APERTE ENTER PARA COMEÇAR:      |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("\\---------------------------------------//");
            Console.ReadKey();


        }

      


    }
 
    
}
