using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_huchani_ElRayoCarreraVeloz
{
    class Program
    {
        static void Main(string[] args)
        {/*El Rayo McQueen está compitiendo en una carrera de alta velocidad. Necesita un programa 
           en C# que le ayude a registrar los tiempos de cada vuelta y calcular algunas estadísticas 
           importantes. 

            El programa debe:
             -Permitir a Rayo McQueen ingresar los tiempos de cada vuelta de la carrera en 
             segundos. Utiliza un array para almacenar estos tiempos.
             -Calcular y mostrar en pantalla el tiempo total de la carrera.
             -Calcular y mostrar en pantalla el promedio de tiempo por vuelta.
             -Determinar y mostrar en pantalla cuál fue la mejor vuelta, es decir, la vuelta con el 
              menor tiempo registrado.
            El programa debe permitir al usuario ingresar la cantidad de vueltas que completó Rayo 
            McQueen y luego ingresar los tiempos de cada vuelta. Al finalizar, mostrará las estadísticas 
            calculadas.*/
            Console.WriteLine("ingrese cuantas vueltas dio McQueen ");
            int vueltas = int.Parse(Console.ReadLine());
            int[] tamaño = new int[vueltas];
            for (int cont = 0; cont < tamaño.Count(); cont++)
            {
                Console.WriteLine("ingrese el tiempo que dio en la vuelta " + (cont + 1));
                int tiempo = int.Parse(Console.ReadLine());
                tamaño[cont] = tiempo;
            }
            int tiempoTotal = 0;
            int mejortiempo = 100;
            for (int cont = 0; cont < tamaño.Count(); cont++)
            {
                tiempoTotal += tamaño[cont];
            }
            for (int i = 0; i < tamaño.Count(); i++)
            {
                if (tamaño[i] < mejortiempo)
                {
                    mejortiempo = tamaño[i];
                }
            }

            Console.WriteLine("el tiempo total de la carrera es: " + tiempoTotal + " seg");
            Console.WriteLine("el tiempo promedio por cada vuelta es: " + (tiempoTotal / vueltas) + " seg");
            Console.WriteLine("el mejor tiempo es : " + mejortiempo + " seg");
            
            Console.ReadKey();
        }
    }
}
