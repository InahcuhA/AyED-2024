using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4_huchani_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {/*En la empresa de videojuegos "Pixel Dreams", se está organizando un torneo en línea de su 
           juego más popular, "Galaxy Quest". Para determinar los ganadores, necesitan un programa 
           que ordene los puntajes de los jugadores de mayor a menor.
           El programa solicitará al usuario que ingrese la cantidad de participantes en el 
           torneo.Luego, pedirá al usuario que ingrese los puntajes de cada participante, 
           uno por uno.Una vez ingresados todos los puntajes, el programa los ordenará de mayor a 
           menor.Finalmente, mostrará la lista de puntajes ordenados, indicando el primer lugar (mayor puntaje) 
           y el último lugar (menor puntaje).*/

            Console.WriteLine("ingrese la cantidad de participantes");

            int Cantparticipantes = int.Parse(Console.ReadLine());
            int[] participantes = new int[Cantparticipantes];
            for (int i = 0; i < participantes.Count(); i++)
            {
                Console.WriteLine("ingrese el puntaje del participante N°" + ( i + 1));
                int puntaje = int.Parse(Console.ReadLine());
                participantes[i] = puntaje;
            }
            int puntajeMayor = 0;
            for (int i = 0; i < participantes.Count(); i++)
            {
                if (participantes[i] > puntajeMayor)
                {
                    puntajeMayor = participantes[i];
                    
                }
                
            }

            for (int i = 0; i < participantes.Count() - 1; i++)
            {
                for (int j = 0; j < participantes.Count() - i - 1; j++)
                {
                    if (participantes[j] < participantes[j + 1]) 
                    {
                        
                        int temp = participantes[j];
                        participantes[j] = participantes[j + 1];
                        participantes[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Puntajes ordenados de mayor a menor:");
            for (int i = 0; i < participantes.Count(); i++)
            {
                Console.WriteLine("Puntaje del participante N°" + (i + 1) + ": " + participantes[i]);
            }

            Console.WriteLine("El primer lugar es: " + participantes[0]);
            Console.WriteLine("El último lugar es: " + participantes[participantes.Count() - 1]);





            Console.ReadKey();
        }
    }
}
