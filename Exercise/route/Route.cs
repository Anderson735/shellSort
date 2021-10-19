using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.route
{
    class Route
    {
        public string bindPath()
        {
            //Español: Establecer la ruta en la cual crea el archivo de texto con los números que se generaron al azar
            //Ingles: Set the path where you create the text file with the randomly generated numbers

            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string route = appPath + "\\ejercicio.txt";
            return route;
        }       

        public string sortRoute()
        {
            //Ingles: Sets the path where the text file will be found with the numbers already ordered
            //Español: Establece la ruta en la cual se encontrará el archivo de texto con los números ya ordenados
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string route = appPath + "\\Shellsort.txt";
            return route;
        }
    }
}
