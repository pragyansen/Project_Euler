using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int ceiling = 2000000; int[] hash = new int[ceiling]; int[] square = new int[10];
            List<int> dividers = new List<int>();
            List<int> semilist = new List<int>();
            for (int i = 2; i <= ceiling; i++)
            {
                dividers.Add(i);
            }
            int p = 2;
            for (int i = 0; i < 10; i++)
                square[i] = i * i;
            while (p * p < ceiling)
            {
                p = dividers[0]; dividers.Remove(p); semilist.Add(p); hash[p] = 1;
                for (int i = 0; i < dividers.Count; i++)
                    if (dividers[i] % p == 0)
                        dividers.Remove(dividers[i]);
            }
            for (int i = 0; i < dividers.Count; i++)
            {
                semilist.Add(dividers[i]); hash[dividers[i]] = 1;
            }
            long sum = 0;
            foreach (int i in semilist)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
