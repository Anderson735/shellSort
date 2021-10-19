using Exercise.randomNumbers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise.ShellSort
{
    class validation
    {
        public static void valide(string range)
        {
            while (true)
            {
                //Español: Valida que el rango que se ingresa sí sea un número entero y sea mayor a 0
                //Ingles: Validate that the range entered is a whole number and is greater than 0
                if (Regex.IsMatch(range, @"^[0-9]+$") && Convert.ToInt32(range) > 0)
                {
                    random.generateAndAddRandomNumbers(Convert.ToInt32(range));
                    Console.WriteLine("Números ya ordenados");
                    Metodo_de_ordenacion.shellShort();
                    break;
                }
                else
                {
                    Console.WriteLine("Ingrese un número entero positivo mayor a 0:");
                    range = Console.ReadLine();
                }
            }
        }
    }
}
