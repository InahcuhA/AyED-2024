using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6_huchani_ZEGARPG
{
    class Program
    {
        static void Main(string[] args)
        {/*La compañía de videojuegos "ZEGA" está desarrollando un nuevo juego de rol (RPG) 
           en el que los jugadores pueden encontrar objetos con diferentes valores. Necesitan un 
           programa que permita identificar en qué posición se encuentran los objetos cuyo valor 
           es mayor a un número dado.

           El programa solicitará al usuario que ingrese la cantidad de elementos (objetos) que 
           desea analizar.Luego, pedirá al usuario que ingrese el valor mínimo que deben tener 
           los objetos para ser considerados en el filtro.Seguidamente, el programa solicitará al 
           usuario que ingrese los valores de los objetos, uno por uno.Una vez ingresados todos 
           los valores, el programa mostrará al usuario las posiciones en las que se encuentran 
           los objetos cuyo valor es mayor al número especificado.*/

            Console.WriteLine("ingrese la canidad de elmentos");
            int elements = int.Parse(Console.ReadLine());
            int[] objetos = new int[elements];
            Console.WriteLine("ingrese el valor minimo que deben tener los elementos para ser considerados en el filtro");
            int valmin = int.Parse(Console.ReadLine());
            for (int i = 0; i < objetos.Count(); i++)
            {
                Console.WriteLine("ingrese un valor al elemento");
                int valorElement = int.Parse(Console.ReadLine());
                if(valorElement > valmin)
                {
                    objetos[i] = valorElement;
                }
            }
            for (int i = 0; i < objetos.Count(); i++)
            {
                Console.WriteLine("objeto: " + objetos[i]);
            }

                Console.ReadKey();
        }
    }
}
