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

// Which of the following numbers are multiples of 4 or 6
List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);
foreach (int num in fourSixMultiples) {
                Console.WriteLine (num);
            }
            Console.WriteLine ();

            // Order these student names alphabetically, in descending order (Z to A)
            Console.WriteLine ("--- Descending Names ---");
            List<string> names = new List<string> () {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };
        List<string> descend = names.OrderByDescending(n => n).ToList();
            foreach (string name in descend) {
                Console.WriteLine (name);
            }
            Console.WriteLine ();

        List<int>whereSquareDo = new List<int>() {
         66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
        };

        List<int> numwhereSquareDo = whereSquareDo.TakeWhile(i =>
        {
        double sqrt = Math.Sqrt(i);
        return sqrt % 1 != 0;
        }).ToList();
    }
}
