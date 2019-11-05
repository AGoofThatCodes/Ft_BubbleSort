using System;

namespace Ft_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5, 0, 3, 1, 10};
            int t;
            Console.WriteLine("Original array :");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            for(int p = 0; p <= numbers.Length - 2; p++)
            {
                for(int i = 0; i <= numbers.Length - 2; i++)
                {
                    if(numbers[i] > numbers[i + 1])
                    {
                        t = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = t;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted Array :");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
