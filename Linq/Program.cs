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

            //Creamos e inicializamos el array de números
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


            //********** FASE 4 **********
            Console.WriteLine("");
            Console.WriteLine("********** FASE 4 **********");

            //Creamos e inicializamos el array de nombres
            string[] arrayNames = new string[7] {"David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            //Obtenemos los nombres que empiezan por "O"
            var startsWithO =
            from name in arrayNames
            where name.StartsWith("O")
            select name;

            Console.WriteLine("Los nombres que empiezan por 'O' son:");

            foreach (string val in startsWithO)
            {
                Console.WriteLine(val);
            }

            //Obtenemos los nombres que tienen más de 6 letras
            var over6Letters =
            from name in arrayNames
            where (name.Length > 6)
            select name;

            Console.WriteLine("Los nombres que tienen más de 6 letras son:");

            //No devuelve nada porque todos los nombres tienen máximo 6 letras
            foreach (string val in over6Letters)
            {
                Console.WriteLine(val);
            }


            //Obtenemos los nombres ordenados descendentemente
            var namesDesc =
            from name in arrayNames
            orderby name descending
            select name;

            Console.WriteLine("Los nombres ordenados descendentemente son:");

            foreach (string val in namesDesc)
            {
                Console.WriteLine(val);
            }

        }
    }
}
