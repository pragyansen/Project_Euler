using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 2, sum = 2;
            while (j < 4000000)
            {
                int temp = i + j;
                i = j; j = temp;
                if (j % 2 == 0)
                    sum += j;
                Console.Write(" " + j);
            }
            Console.WriteLine(" "+sum);
            Console.ReadKey();
        }
    }
}
