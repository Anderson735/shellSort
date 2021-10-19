using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Exercise.lists;
using Exercise.route;

namespace Exercise.randomNumbers
{
    class random
    {
        public static void generateAndAddRandomNumbers(int range)
        {
            Lists lists = new Lists();
            Route route = new Route();
            Random Random = new Random();
            StringBuilder sb = new StringBuilder();
            string starTime = DateTime.Now.ToString("hh:mm:ss:fff tt");
            string finalTime = DateTime.Now.ToString("hh:mm:ss:fff tt");

            Console.WriteLine($"Tiempo de inicio: {starTime}");


            //Español: Agrega números random a la lista
            //Ingles: Add the random numbers to the list
            for (int a = 1; a < range + 1; a++)
            {
                lists.numbersToSave.Add(Random.Next(-1000, 999 + 1));

            }

            //Español: Agregue los números que se insertaron en la lista al archivo de texto
            //Ingles: Add the numbers that were inserted into the list to the text file
            foreach (var item in lists.numbersToSave)
            {
                sb.AppendLine(item.ToString());
            }
            File.WriteAllText(route.bindPath(), sb.ToString());
            Console.WriteLine($"Tiempo final: {finalTime}");          
        }
    }
}
