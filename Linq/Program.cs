using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //********** FASE 1 **********
            Console.WriteLine("********** FASE 1 **********");
            int[] arrayNumbers = new int[15] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
            
            //Realizamos la query forzando la ejecución para que guarde en un array
            var evenNumsQuery = 
            (from num in arrayNumbers
            where (num % 2) == 0
            select num).ToArray();

            //Imprimimos por pantalla los valores obtenidos del array de números pares
            foreach(int val in evenNumsQuery)
            {
                Console.WriteLine(val);
            }


            //********** FASE 2 **********
            Console.WriteLine("");
            Console.WriteLine("********** FASE 2 **********");

            //Obtenemos la nota máxima
            var maxMark =
            (from num in evenNumsQuery
            select num).Max();

            Console.WriteLine("la nota más alta de los valores pares es: " + maxMark);


            //Obtenemos la nota mmínima
            var minMark =
            (from num in evenNumsQuery
            select num).Min();

            Console.WriteLine("la nota más baja de los valores pares es: " + minMark);


            //Obtenemos la nota media
            var averageMark =
            (from num in evenNumsQuery
            select num).Average();

            Console.WriteLine("la nota más baja de los valores pares es: " + averageMark);


            //********** FASE 3 **********
            Console.WriteLine("");
            Console.WriteLine("********** FASE 3 **********");

            //Obtenemos los valores por debajo de 5
            var underFive =
            from num in evenNumsQuery
            where num < 5
            select num;

            Console.WriteLine("Los valores por debajo de 5 son:");

            foreach(int val in underFive)
            {
                Console.WriteLine(val);
            }


            //Obtenemos los valores por encima de 5
            var overFive =
            from num in evenNumsQuery
            where num > 5
            select num;

            Console.WriteLine("Los valores por encima de 5 son:");

            foreach (int val in overFive)
            {
                Console.WriteLine(val);
            }

        }
    }
}
