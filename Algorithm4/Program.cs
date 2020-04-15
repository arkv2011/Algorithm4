using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algs4Lib;

namespace Algorithm4
{
    class Program
    {

        static void RandomTest()
        {
            int count = 0;
            for(int i=0;i<10000;i++)
            {
                if (StdRandom.bernoulli())
                    ++count;
            }
            Console.WriteLine($"True:{count}\nFalse:{10000 - count}");
        }

        static void Main(string[] args)
        {
            RandomTest();
        }
    }
}
