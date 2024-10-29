using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp11_huchani_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {/*Sumar dos matrices de igual tamaño nxn.*/

            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int[,] C = new int[3, 3];

            Random aleatorio = new Random();

            for (int i = 0; i < 3 ; i++)
            {
                for (int j = 0; j < 3 ; j++)
                {
                    A[i, j] = aleatorio.Next(1,10);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("                   +");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    B[i, j] = aleatorio.Next(1, 10);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(C[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
