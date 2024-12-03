using System;
using System.IO;
using System.Collections.Generic;

namespace Sorting_with_menus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }

    class FileManager
    {
        List <int> numbers = new List<int>();

        List<string> fileContents = File.ReadAllLines('../');



    }
}
