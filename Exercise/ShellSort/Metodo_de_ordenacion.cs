using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Exercise.lists;
using Exercise.route;


namespace Exercise.ShellSort
{
    class Metodo_de_ordenacion
    {       
        public static void shellShort()
        {
            Lists Lists = new Lists();
            StringBuilder sb = new StringBuilder();
            Route route = new Route();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string starTime = DateTime.Now.ToString("hh:mm:ss:fff tt");
            string finalTime = DateTime.Now.ToString("hh:mm:ss:fff tt");

            


            //Español: Lee el archivo de texto y toma los números para luego insertarlos en la lista

            //Ingles: Read the text file and take the numbers and then insert them into the list
            using (StreamReader leer = new StreamReader(route.bindPath()))
            {
                //Español: Inserta los números que están dentro del archivo de texto en una lista
                //Ingles: Insert the numbers that are inside the text file in a list
                while (!leer.EndOfStream)
                {
                    int x = Convert.ToInt32(leer.ReadLine());
                    Lists.textFileNumbers.Add(x);
                }

                //Shell sort
                int i, j, pos, temp;
                pos = 3;
                int n = Lists.textFileNumbers.Count;
                while (pos > 0)
                {
                    for (i = 0; i < n; i++)
                    {
                        j = i;
                        temp = Lists.textFileNumbers[i];
                        while ((j >= pos) && (Lists.textFileNumbers[j - pos] > temp))
                        {
                            Lists.textFileNumbers[j] = Lists.textFileNumbers[j - pos];
                            j = j - pos;
                        }
                        Lists.textFileNumbers[j] = temp;
                    }
                    if (pos / 2 != 0)
                        pos = pos / 2;
                    else if (pos == 1)
                        pos = 0;
                    else
                        pos = 1;
                }

                //Español: Recorre la lista y va mostrando cada número en pantalla de forma ordenada
                //Ingles: Scrolls through the list and shows each number on the screen in an orderly manner
                foreach (var k in Lists.textFileNumbers)
                {
                    Console.WriteLine(k);
                }
                watch.Stop();

                TimeSpan timeSpan = watch.Elapsed;

                Console.WriteLine("Tiempo que se tardo en ordenar {0} datos e imprimirlos por pantalla: {1}h {2}m {3}s {4}ms", Lists.textFileNumbers.Count, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);

                //Español: Inserta los números ya de forma ordenada en un nuevo archivo de texto
                //Ingles: Insert the numbers already neatly into a new text file
                Console.WriteLine($"Tiempo en el que empezo a guardar el listado ya ordenado: {starTime}");
                foreach (var item in Lists.textFileNumbers)
                {
                    sb.AppendLine(item.ToString());
                }
                File.WriteAllText(route.sortRoute(), sb.ToString());
                Console.WriteLine($"Tiempo en el que finalizo: {finalTime}");
            }
        }
    }
}
