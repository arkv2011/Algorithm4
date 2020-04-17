using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algs4Lib
{
    public class StdRandom
    {
        /// <summary>
        /// Seed of the random generator.
        /// </summary>
        static long seed = DateTime.Now.Millisecond;
        static Random rdm = new Random();

        /// <summary>
        /// 
        /// </summary>
        public static long Seed
        {
            get { return seed; }
            set
            {
                seed = value;
                rdm = new Random(Convert.ToInt32(seed));
            }

        }

        public static double uniform()
        {
            return rdm.NextDouble();
        }

        public static int uniform(int N)
        {
            if (N <= 0)
                throw new ArgumentOutOfRangeException("N", "Argument must be positive");
            return rdm.Next(N);
        }

        public static double uniform(int a, int b)
        {
            if (b >= a)
                throw new ArgumentException($"Invalid range:[{a}, {b})");
            return a + uniform() * (b - a);
        }

        public static bool bernoulli(double p)
        {
            if (p > 1 || p < 0)
                throw new ArgumentOutOfRangeException("p", "p must be between 0.0 and 1.0");
            return uniform() < p;
        }

        public static bool bernoulli()
        {
            return bernoulli(0.5);
        }

        public static double goussian()
        {
            double r, x, y;
            do 
            {
                x = uniform(-1, 1);
                y = uniform(-1, 1);
                r = x * x+  y * y;
            }while(r>=1 || r==0);

            return x * Math.Sqrt(-2 * Math.Log(r) / r);
        }

        public static double goussian(double mu, double sigma)
        {
            return mu + sigma * goussian();
        }
    }
}
