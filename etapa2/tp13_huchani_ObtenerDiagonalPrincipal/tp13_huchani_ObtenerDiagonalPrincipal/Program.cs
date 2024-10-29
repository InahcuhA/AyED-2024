using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp13_huchani_ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Usando un for y un vector se debe obtener la diagonal principal de una 
            Matriz nxn con datos aleatorios.*/

            Console.WriteLine("ingrese un valor");
            int n = int.Parse(Console.ReadLine());
            Random aleatorio = new Random();
            int[,] matris = new int[n, n];
            for (int c = 0; c < n; c++)
            {

                for (int f = 0; f < n; f++)
                {
                    matris[c, f] = aleatorio.Next(0, 10);
                    Console.Write(matris[c, f] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = matris[i, i];
                Console.Write(vector[i] + "\t");

            }


            Console.ReadKey();
        }
    }
}
