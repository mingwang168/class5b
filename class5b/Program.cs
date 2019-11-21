using System;

namespace class5b
{

    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int[] intArray = new int[] { 1, 2, 3 };

            Console.WriteLine(x);
            Console.WriteLine();
            foreach (int y in intArray)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("---------------------------------------------------------------------");

            AddOne(x);
            AddOne(intArray);

            Console.WriteLine(x);
            foreach (int y in intArray)
            {
                Console.WriteLine(y);
            }

            Console.ReadLine();
        }

        static void AddOne(int x)
        {
            x++;
        }

        static void AddOne(int[] intArray)
        {
            for (int x = 0; x < intArray.Length; x++)
            {
                intArray[x]++;
            }
        }

    }
}
