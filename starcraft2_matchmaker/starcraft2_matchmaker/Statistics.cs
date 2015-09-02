using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starcraft2_matchmaker
{
    public static class Statistics
    {
        public static double StdDev(double[] t)
        {
            double mean = Mean(t);
            double sum = 0.0;
            for (int i = 0; i < t.Length; i++)
            {
                double delta = t[i] - mean;
                sum += delta * delta;
            }
            return Math.Sqrt(sum / (t.Length - 1));
        }

        public static double Mean(double[] t)
        {
            double sum = 0.0;
            for (int i = 0; i < t.Length; i++)
            {
                sum += t[i];
            }
            return sum /= t.Length;
        }
    }
}
