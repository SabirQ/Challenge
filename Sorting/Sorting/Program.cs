using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 8, 1, 5, 6, 82, 34, 9, 23, 7, 56, 0 };
            
            
            int change;

            for (int i = 0; i < numbers.Length-1;)
            {
                if (numbers[i] > numbers[i+1])
                {
                    change = numbers[i+1];
                    numbers[i+1] = numbers[i];
                    numbers[i] = change;
                    i = 0;
                    

                }
                else
                {
                    i++;
                }
            }



            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }










        }
    }
}
