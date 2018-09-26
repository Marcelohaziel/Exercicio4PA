using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aluno maiores de idade");
            Console.WriteLine();

            int i = 1;
            int n1 = 0;
            int quantMaiores = 0;

            while (i <= 8)
            {
                Console.Write("Digite a idade do  " + i + " aluno: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                if (n1 >= 18)
                {
                    quantMaiores++;
                }
                i++;
            }
            Console.WriteLine();

            Console.WriteLine("Quantidade de numeros pares: " + quantMaiores);

            Console.ReadKey();
        }
    }
}
