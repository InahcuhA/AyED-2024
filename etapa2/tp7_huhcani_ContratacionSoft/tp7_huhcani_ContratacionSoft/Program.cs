using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7_huhcani_ContratacionSoft
{
    class Program
    {
        static void Main(string[] args)
        {/*Una empresa de desarrollo de software está en proceso de contratar un nuevo equipo para 
           un proyecto importante. Durante el proceso de selección, necesitan un programa que 
           ordene los puntajes obtenidos en un examen de menor a mayor, y luego filtre aquellos 
           puntajes que sean múltiplos de un número dado.

           El programa solicitará al usuario que ingrese la cantidad de candidatos que realizaron el 
           examen.Luego, pedirá al usuario que ingrese los puntajes de cada candidato, uno por 
           uno.Una vez ingresados todos los puntajes, el programa los ordenará de menor a 
           mayor.Posteriormente, el programa solicitará al usuario que ingrese un número entero para 
           filtrar los puntajes múltiplos de ese número.Finalmente, mostrará al usuario la lista de 
           puntajes ordenados y los puntajes que son múltiplos del número especificado.*/

            Console.WriteLine("ingrse la cantidad de personas que hicieron el examen");
            int examreal = int.Parse(Console.ReadLine());
            int[] candidatos = new int[examreal];
            Console.WriteLine("ingrese un numero entero para filtrar los multiplos de lo que pusiste");
            int filtro = int.Parse(Console.ReadLine());
            for (int i = 0; i < candidatos.Count(); i++)
            {
                Console.WriteLine("ingrese el puntaje en cada candidato n°" + (i + 1));
                int puntaje = int.Parse(Console.ReadLine());
                if (puntaje % filtro == 1)
                {
                    candidatos[i] = puntaje;
                }                      
                else if (puntaje % filtro == 0)
                {
                    candidatos[i] = puntaje;
                }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
                                    
            }
            for (int i = 0; i < candidatos.Count() - 1; i++)
            {
                for (int j = 0; j < candidatos.Count() - 1 - i; j++)
                {
                    if (candidatos[j] < candidatos[j + 1])
                    {
                        int temp = candidatos[j];
                        candidatos[j] = candidatos[j + 1];
                        candidatos[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < candidatos.Count(); i++)
            {
                Console.WriteLine("    " + candidatos[i]);
            }
            Console.ReadKey();
        }
    }
}
