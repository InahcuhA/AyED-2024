using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp10_huchani_MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese cuantas filas ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese valor columnas");
            int c = int.Parse(Console.ReadLine());
            int[,] A = new int[f, c];
            Random random = new Random();


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    A[i, j] = random.Next(1, 10);
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
