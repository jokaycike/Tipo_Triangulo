using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Triangulo
    {
        static void Main(string[] args)
        {
            Denovo();
        }
        public static void Denovo()
        {
            double A;
            double B;
            double C;

            Console.WriteLine("Vamos descobrir qual e os seu tipo de triângulo:");

            Console.WriteLine("Digite o valor do lado A do triângulo");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B do triângulo");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C do triângulo");
            C = double.Parse(Console.ReadLine());


            if(A == B && B == C)
            {
                Console.Write("Esse triângulo é: \t");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Equilátero \n");
                Console.ResetColor();
            }
            else if(A == B || A == C || B == C)
            {
                Console.Write("Esse triângulo é: \t");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Isósceles \n");
                Console.ResetColor();
            }
            else if (A != C && A != B && B != C ) 
            {
                Console.Write("Esse triângulo é: \t");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Escaleno \n");
                Console.ResetColor();
            }

            Denovo();
        }
    }
}
