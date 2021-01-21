using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("");
                Console.WriteLine("----------------");

                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtação");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");

                Console.WriteLine("-------------");

                Console.WriteLine("0. Sair");
                Console.WriteLine("-------------");

                Console.WriteLine("Opção");
                string opcao = Console.ReadLine();
                double a = 0;
                double b = 0;

                //Sair da aplicação

                if (opcao == "0")Environment.Exit(0);

                //Pedir os valores

                Console.Write("A= ");
                a = double.Parse(Console.ReadLine());
                Console.Write("B= ");
                b = double.Parse(Console.ReadLine());

                //executar operação escolhida

                if (opcao == "1")
                {
                    Console.WriteLine(a + " + " + b + " = " + (a+b).ToString());
                }
                else if(opcao == "2")
                {
                    Console.WriteLine(a + "-" + b + " = " + (a-b).ToString());
                }
                else if (opcao == "3")
                {
                    Console.WriteLine(a + "*" + b + " = " + (a*b).ToString());
                }
                else if (opcao == "4")
                {
                    Console.WriteLine(a + "/" + b + " = " + (a / b).ToString());
                }
            }
        }
    }
}
