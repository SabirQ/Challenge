using System;

namespace _10sumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 0, 2,3, 4, 5, 6, 7, 9, 10 };
            int[] SumofTen = new int[0];
            int f = 0;

            for (int i = 1;f<num.Length-1; i++)
            {
                if (i < num.Length)
                {
                    if (num[f] + num[i] == 10)
                    {
                        Array.Resize(ref SumofTen, SumofTen.Length + 1);
                        SumofTen[SumofTen.Length - 1] = num[f];
                        Array.Resize(ref SumofTen, SumofTen.Length + 1);
                        SumofTen[SumofTen.Length - 1] = num[i];
                    }                    
                }
                else 
                {                   
                    i = f+1;
                    f++;
                }               
            }

            foreach (int numbers in SumofTen)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
