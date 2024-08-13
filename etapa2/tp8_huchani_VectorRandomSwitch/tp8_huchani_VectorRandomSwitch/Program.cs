using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp8_huchani_VectorRandomSwitch
{
    class Program
    {
        static void Main(string[] args)
        {/*El objetivo de este ejercicio es crear un programa que utilice un vector, números 
           aleatorios generados con la función Random y una estructura de control switch para 
           realizar las siguientes acciones:

           1)  Se crea un vector de tamaño n, donde n es un valor ingresado por el usuario.
           2)  Se utiliza la función Random para generar números aleatorios entre un rango definido 
           y se llenan las posiciones del vector con estos valores.
           3)  Se presenta al usuario un menú con las siguientes opciones:
           
           -Imprime en pantalla todos los elementos del vector.
           -El usuario ingresa un número y el programa busca 
           si este se encuentra en el vector. Si lo encuentra, se indica la posición en la que se encuentra.
           -Se ordena el vector de forma ascendente o descendente, según la elección del usuario.
           -Termina la ejecución del programa.
           
           El programa utiliza la estructura de control switch para evaluar la opción seleccionada 
           por el usuario y ejecutar la acción correspondiente.*/

            Console.WriteLine("ingrese un valor para el vector");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            Random aleatorio = new Random();

            for (int i = 0; i < vector.Count(); i++)
            {
                vector[i] = aleatorio.Next(0, 10);
            }

            bool band = true;
            while (band != false)
            { 
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Imprimir todos los elementos del vector");
                Console.WriteLine("2. Buscar un número en el vector");
                Console.WriteLine("3. Ordenar el vector");
                Console.WriteLine("4. Terminar la ejecución del programa");

                int opcion = int.Parse(Console.ReadLine());
                

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Elementos del vector:");
                        for (int i = 0; i < vector.Count(); i++)
                        {
                            Console.WriteLine(vector[i]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("ingrese un valor para buscar en el vector");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 0; i < vector.Count(); i++)
                        {
                            if (num == vector[i])
                            {
                                Console.WriteLine("el valor esta en la casilla " + i + " del vector");
                            }
                            
                        }
                        break;
                    case 3:
                        Console.WriteLine("como quiere que se ordene el vectorde manera *ascendente* o *descendente*");
                        string orden = (Console.ReadLine());
                        if (orden == "ascendente")
                        {
                            for (int i = 0; i < vector.Count() - 1; i++)
                            {
                                for (int j = 0; j < vector.Count() - i - 1; j++)
                                {
                                    if (vector[j] > vector[j + 1])
                                    {
                                        int aux = vector[j];
                                        vector[j] = vector[j + 1];
                                        vector[j + 1] = aux;
                                    }
                                }
                            }
                            for (int i = 0; i < vector.Count(); i++)
                            {
                                Console.WriteLine(vector[i]);
                            }
                        }
                        else if (orden == "descendente")
                        {
                            for (int i = 0; i < vector.Count() - 1; i++)
                            {
                                for (int j = 0; j < vector.Count() - i - 1; j++)
                                {
                                    if (vector[j] < vector[j + 1])
                                    {
                                        int aux = vector[j];
                                        vector[j] = vector[j + 1];
                                        vector[j + 1] = aux;
                                    }
                                }
                            }
                            for (int i = 0; i < vector.Count(); i++)
                            {
                                Console.WriteLine(vector[i]);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("hasta la vista!!! \n apreta cualquier tecla");
                        band = false;
                        break;


                }
             }
            Console.ReadKey();
        }
    }
}
