using System;

namespace Primeirogit
{
    class Program
    {
        static void Main(string[] args)
        {
         /*
         
         desclaração das variáveis para guardar os valores que o usuário entrará
          */
         double valor1,valor2,resultado;
         Console.WriteLine("digite um valor");
         valor1 = double.Parse(Console.ReadLine());
         Console.WriteLine("entre com outro valor");
         valor2 = double.Parse(Console.ReadLine());
         resultado = valor1 + valor2;
         Console.WriteLine("o resultado da soma é "+resultado);
        }
    }
}
