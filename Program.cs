using System;
using System.IO;
using System.Collections.Generic;

namespace Sorting_with_menus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../NumSets/NumSet_Small.csv";
            Console.WriteLine("Hello, World!");

            if (File.Exists(filePath))
            {
                var numbers = File.ReadLines(filePath)
                    .Where((line) => !line.StartsWith('#') && !string.IsNullOrWhiteSpace(line)).ToList()
                    .SelectMany((line) => line.Split(','))
                    .Select((number) => int.Parse(number)).ToList();

                // For testing!!!
                foreach (var number in numbers) {
                    Console.WriteLine(number);
                }
            }






        }

    }

    class FileManager
    {
       
    }
}
