using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2 * 3 * 5 * 7 * 11 * 13 * 17 * 19;
            i *= 2 * 2 * 2 * 3;
            Console.Write(i);
            
            for(int j = 1; i<=20;i++ )
            {
                if (i % j != 0)
                    Console.WriteLine(j);

            }
            Console.ReadKey();
        }
    }
}
