using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp9_huchani_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {/* Crear una matriz de n×m con todos sus elementos inicializados a cero.  Imprimirla por 
            pantalla

            n y m son datos que ingresa el usuario*/

            int[,] A = new int[3, 3];
            for (int i = 0; i < A.GetLength(1); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = 0;
                }
            }


            for (int i = 0; i < A.GetLength(1); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
