using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp12_huchani_RotarMatriz90
{
    class Program
    {
        static void Main(string[] args)
        {/*Rotar una matriz cuadrada n×n 90 grados en sentido horario.*/

            int[,] matris1 = new int[3, 3];
            Random aleatorio = new Random();

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    matris1[f, c] = aleatorio.Next(1, 10);
                }
            }

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(matris1[f, c] + "  ");
                }
                Console.WriteLine();
            }
            

            int[,] matris90 = new int[3, 3];
      
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    matris90[f, 3 - 1 - c] = matris1[c, f];
                }
                
            }
            Console.WriteLine("ROTADO");

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(matris90[f, c] + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
