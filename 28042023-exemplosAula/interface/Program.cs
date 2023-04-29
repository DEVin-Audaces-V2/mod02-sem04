using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            int soma = calculadora.Somar(1, 2);
            int sub = calculadora.Subtrair(2, 2);

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtração: " + sub);
        }
    }
}