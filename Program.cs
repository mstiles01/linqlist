using System;
using System.Collections.Generic;
using System.Linq;

namespace linqprac
{
    class Program
    {
        static void Main(string[] args)
        {
           // Find the words in the collection that start with the letter 'L'
List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

IEnumerable<string> LFruits = fruits.Where(word => word.StartsWith("L"));
foreach (string fruit in LFruits) {
    Console.WriteLine (fruit);
}
Console.WriteLine();
        }
    }
}
