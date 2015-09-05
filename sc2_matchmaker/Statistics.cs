/*This file is part of SC 2 Matchmaker.

SC 2 Matchmaker is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 3 of the License.

SC 2 Matchmaker is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with SC 2 Matchmaker. If not, see<http://www.gnu.org/licenses/>.

Copyright Damien Dosimont, 2015 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sc2_matchmaker
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
