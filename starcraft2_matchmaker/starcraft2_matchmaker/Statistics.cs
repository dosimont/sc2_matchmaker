using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starcraft2_matchmaker
{
    public static class Statistics
    {
        public static double StdDev(int[] t)
        {
            double mean = Mean(t);
            double sum = 0.0;
            for (int i = 0; i < t.Length; i++)
            {
                double delta = (double) t[i] - mean;
                sum += delta * delta;
            }
            return Math.Sqrt(sum / (t.Length));
        }

        public static double Mean(int[] t)
        {
            double sum = 0.0;
            for (int i = 0; i < t.Length; i++)
            {
                sum += (double) t[i];
            }
            return sum /= t.Length;
        }
    }
}
