using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp14_huchani_CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear una matriz Nx3 donde cada fila representa un estudiante y 
            cada columna contiene información como el nombre, la edad y la calificación.*/
            Console.WriteLine("coloque la cantidad de estidiantes");
            int n = int.Parse(Console.ReadLine());
            string[,] matris = new string[3, n];
            Console.WriteLine("pon el nombre la edad y la calificasion \n apreta enter cuando pones un dato");
            for (int c = 0; c < n; c++)
            {
                for (int f = 0; f < 3; f++)
                {
                    
                    matris[f, c] = Console.ReadLine();

                    
                }
            }
            Console.Clear();

            Console.WriteLine(" nombre|edad|calificasion  ");
            for (int c = 0; c < n; c++)
            {
                for (int f = 0; f < 3; f++)
                {
                    Console.Write(matris[f, c] + "\t");                   
                }
                Console.WriteLine();
            }





            Console.ReadKey();
        }
    }
}
