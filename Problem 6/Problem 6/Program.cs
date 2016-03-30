using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, square_sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                square_sum += i * i;
            }
            sum = sum * sum;
            Console.WriteLine(sum +"-" +square_sum+"="+(sum - square_sum));
            Console.ReadKey();
        }
    }
}
