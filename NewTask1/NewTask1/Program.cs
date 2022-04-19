using System;

namespace NewTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find a big value \n");

            int[] numbers = { 5, 36, 23, 45, 15, 92, -5, 3, 33,79 };
            int max = numbers[0];
            
            foreach (int num in numbers)
            {
                Console.Write(num + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("\n");
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Max Value in Array : "  + max);



        }
    }
}
