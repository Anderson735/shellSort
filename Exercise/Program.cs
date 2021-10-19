using System;
using System.Linq;
using System.Text.RegularExpressions;
using Exercise.randomNumbers;
using Exercise.ShellSort;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de elementos que quiere que se generen:");
            string range = Console.ReadLine();
            validation.valide(range);           
        }
    }
}


        
    

