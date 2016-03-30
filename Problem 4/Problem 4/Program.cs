using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int data = 0;
            for(int j = 999;j > 100;j--)
            for (int i = 999; i > 100; i--)
            {
                int k = i * j;
                string match = k.ToString();
                if(match.Length==6)
                if (match[0] == match[5] && match[1] == match[4] && match[2] == match[3])
                { if (data < i * j) data = i * j; }
            }
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
