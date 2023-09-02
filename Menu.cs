using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Calculator
{
    public class Menu : Operacoes
    {
        public static void MenuDoUsuario()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a sua calculadora virtual simples! O que deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair da aplicação! ");

            Console.WriteLine("--------------");
            int resposta;
            Console.WriteLine("Selecione uma opção: ");
            while (!int.TryParse(Console.ReadLine(), out resposta) || resposta < 0 || resposta > 4)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite uma opção válida: ");
            }
                if (resposta != 0)
                {
                    try
                    {
                        switch (resposta)
                        {
                            case 1:
                                Console.Clear();
                                System.Console.WriteLine("Você Escolheu a soma!");
                                Soma();
                                MenuDoUsuario();

                                break;

                            case 2:
                                Console.Clear();
                                System.Console.WriteLine("Você Escolheu a Subtração");
                                Subtracao();
                                MenuDoUsuario();
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Você Escolheu a Multiplicação");
                                Multiplicacao();
                                MenuDoUsuario();
                                break;

                            case 4:
                                Console.Clear();
                                System.Console.WriteLine("Você Escohleu a Divisão");
                                Divisao();
                                MenuDoUsuario();
                                break;
                        }
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine($"Não é possível dividir por zero! \nRetornando ao menu Inicial...");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Entrada de valor Inválida por favor digite um Número válido! \nRetornando ao menu inicial... ");

                    }
                    Thread.Sleep(4000);
                    MenuDoUsuario();


                }

                else
                {
                    Environment.Exit(0);
                }
            
            
        }



    }
}











