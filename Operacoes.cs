using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operacoes
    {
    public static void Soma()
    {  
        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

       Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("");
        float resultado = v1 + v2;
        System.Console.WriteLine($"O resultado da soma é: {resultado}\nPressione qualquer tecla para voltar ao Menu inicial!... ");
        Console.ReadKey();

    }

    public static void Subtracao()
    {
        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

       Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("");
        float resultado = v1 - v2;
        System.Console.WriteLine($"O resultado da subtração é: {resultado}\nPressione qualquer tecla para voltar ao Menu inicial!... ");
        Console.ReadKey();

    }

    public  static void Divisao()
    {

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            if (v2 == 0) 
            { 
                throw new DivideByZeroException();
            }
            else
            {
                System.Console.WriteLine("");
                float resultado = v1 / v2;
                System.Console.WriteLine($"O resultado da divisão é: {resultado} \nPressione qualquer tecla para voltar ao Menu inicial!...");
                Console.ReadKey();
            }

            
           
         
          


    }

        public static void Multiplicacao()
    {
        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

       Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        System.Console.WriteLine("");
        float resultado = v1 * v2;
        System.Console.WriteLine($"O resultado da multiplicação é: {resultado} \nPressione qualquer tecla para voltar ao Menu inicial!...");
        Console.ReadKey();

    }
    }
}
