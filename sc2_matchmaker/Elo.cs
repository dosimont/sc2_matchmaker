/*This file is part of SC 2 Matchmaker.

SC 2 Matchmaker is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 3 of the License.

SC 2 Matchmaker is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Foobar.  If not, see<http://www.gnu.org/licenses/>.

Copyright Damien Dosimont, 2015 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sc2_matchmaker
{
    public static class Elo
    {
        public static int getK(Player player, int race)
        {
            int K = Constants.K3;
            if ((player.Victory[race] + player.Defeat[race]) < Constants.K1seuil_games)
            {
                K = Constants.K1;
            }
            else if (player.Elo[race] < Constants.K2seuil_elo)
            {
                K = Constants.K2;
            }
            return K;
        }

        public static void compute(bool victory, Player player, int race, int eloTeam, int eloAdv, int teamNumber)
        {
            int W = Constants.WDefeat;
            int coeff;
            if (victory)
            {
                W = Constants.WVictory;
                player.Victory[race]++;
                coeff = teamNumber - 1;
            }
            else
            {
                player.Defeat[race]++;
                coeff = 1;
            }
            double incr = (double) getK(player, race) * ((double) W - proba(eloTeam, eloAdv)) * coeff;
            player.Elo[race] += (int)incr;
        }

        public static double proba(int eloTeam, int eloAdv)
        {
            double D = Math.Max(Math.Min((eloTeam - eloAdv), (double) Constants.MaxD), (double) - Constants.MaxD);
            return 1 / (1 + Math.Pow(10, - D/(double) Constants.MaxD));
        }
    }
}
