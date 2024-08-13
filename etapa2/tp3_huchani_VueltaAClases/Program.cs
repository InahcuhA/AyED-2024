using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3_huchani_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {/*Después de unas largas vacaciones llenas de aventuras, Phineas y Ferb regresan a la 
            escuela. Sin embargo, como no estudiaron durante las vacaciones, necesitan un sistema 
            que les ayude a determinar si podrán aprobar la materia.
            El sistema debe permitir a Phineas y Ferb ingresar la cantidad de trabajos prácticos (TPs) 
            y exámenes que tienen en la materia. Luego, deben ingresar las notas de cada TP y 
            examen.
            Para aprobar la materia, Phineas y Ferb deben cumplir dos condiciones:
            
            - El promedio de las notas de los exámenes debe ser mayor o igual a 6.
            - Al menos el 75% de los TPs deben tener una nota igual o mayor a 6.
            
            El sistema debe calcular el promedio de los exámenes y verificar si se cumplen las 
            condiciones para aprobar la materia. Finalmente, debe mostrar en pantalla un mensaje 
            indicando si Phineas y Ferb pueden aprobar la materia o no.
            
            - Permitir al usuario especificar la cantidad de TPs y exámenes.
            - Permitir al usuario ingresar las notas de cada TP y examen.
            - Calcular el promedio de las notas de los exámenes.
            - Verificar si se cumplen las condiciones para aprobar la materia.
            - Mostrar un mensaje indicando si Phineas y Ferb pueden aprobar la materia.*/

            Console.WriteLine("ingrese la cantidad de TPs");
            int cantTPs = int.Parse(Console.ReadLine());
            int[] TPS = new int[cantTPs];
            for (int i = 0; i < TPS.Count(); i++)
            {
                Console.WriteLine("ingrese la nota de los TPs");
                Console.WriteLine("trabajo practico N°" + (i + 1) + "\n" + "nota: ");

                int notadetps = int.Parse(Console.ReadLine());
                if ((notadetps >= 1) && (notadetps <= 10))
                {
                    TPS[i] = notadetps;
                }
                else
                {
                    Console.WriteLine("\n" + "ERROR, la nota debe ser entre el 1 hasta el 10" + "\n");
                    i--;
                }
            }



            Console.WriteLine("\n"+"ingrese la cantidad de examenes"+ "\n");
            int CantExamenes = int.Parse(Console.ReadLine());
            int[] Examenes = new int[CantExamenes];
            for (int i = 0; i < Examenes.Count(); i++)
            {
                Console.WriteLine("ingrese la nota de los examenes");
                Console.WriteLine("el examen N°" + (i + 1) + "\n" + "nota: ");

                int notadeexam = int.Parse(Console.ReadLine());
                if ((notadeexam >= 1) && (notadeexam <= 10))
                {
                    Examenes[i] = notadeexam;
                }
                else
                {
                    Console.WriteLine("\n" + "ERROR, la nota debe ser entre el 1 hasta el 10" + "\n");
                    i--;
                }
            }

            int TpsAprobados = 0;

            for (int i = 0; i < TPS.Count(); i++)
            {
               if (TPS[i] >= 6)
                {
                    TpsAprobados += 1 ;
                }
            }

            int totaldeExamenNotas = 0;

            for (int i = 0; i < Examenes.Count(); i++)
            {
                totaldeExamenNotas += Examenes[i];
            }

            int notaTPS = (TpsAprobados * 100 / cantTPs );
            int promedioExam = (totaldeExamenNotas / CantExamenes);


            if (promedioExam >= 6 && notaTPS >= 75)
            {
                Console.WriteLine("phinias y ferb pueden aprobar la materia");
                Console.WriteLine("aprobo con el " + notaTPS + "% de los tps aprobados");

            }
            else
            {
                Console.WriteLine("phineas y ferb no pueden aaprobar la materia");
                Console.WriteLine("no aprueba con el " + notaTPS + "% de los tps aprobados");
            }
            Console.WriteLine("promedio de las notas de los examenes: " + promedioExam);
            

            Console.ReadKey();
        }
    }
}
