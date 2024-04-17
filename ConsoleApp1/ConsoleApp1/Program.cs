using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, r;
            string op;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Informe o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o primeiro número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escolha a Operação(A / S / M / D): ");
            op = Console.ReadLine().ToUpper();

            if (op == "A")
            {
                r = (n1 - n2);
                Console.Write("A adição de "+ n1 +" - "+ n2 +" = "+r);
            }
            else if (op == "S")
            {
                r = (n1 + n2);
                Console.Write("A Soma de " + n1 + " + " + n2 + " = " + r);
            }
            else if (op == "M")
            {
                r = (n1 * n2);
                Console.Write("A multiplicação de " + n1 + " * " + n2 + " = " + r);
            }
            else if (op == "D")
            {
                r = (n1 / n2);
                Console.Write("A divisão de " + n1 + " / " + n2 + " = " + r);
            }
            else
            {
                Console.Write("Opção invalida!");
            }

            Console.ReadKey();
        }
    }
}
