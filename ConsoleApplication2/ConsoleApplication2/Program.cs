using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int[] num = new int[] { 2, 3, 1, 7, 5, 8, 6, 9, 4, 10 };
            for (int a = 0; a < num.Length - 1; a++)
            {
                for (int b = 0; b < num.Length - 1 - a; b++)
                {
                    if (num[b] < num[b + 1])
                    {
                        temp = num[b];
                        num[b] = num[b + 1];
                        num[b + 1] = temp;
                    }
                }
            }
            foreach (int result in num)
            {
                Console.Write(result + " ");
            }
            Console.ReadKey();
        }
    }
}