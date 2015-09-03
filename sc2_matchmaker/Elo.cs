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

        public static void compute(bool victory, Player player, int race, int eloTeam, int eloAdv)
        {
            int W = Constants.WDefeat;
            if (victory)
            {
                W = Constants.WVictory;
                player.Victory[race]++;
            }
            else
            {
                player.Defeat[race]++;
            }
            double incr = (double) getK(player, race) * ((double) W - proba(eloTeam, eloAdv));
            player.Elo[race] += (int) incr;
            if (player.Elo[race] < 0)
            {
                player.Elo[race] = 0;
            }
        }

        public static double proba(int eloTeam, int eloAdv)
        {
            double D = Math.Max(Math.Min((eloTeam - eloAdv), (double) Constants.MaxD), (double) - Constants.MaxD);
            return 1 / (1 + Math.Pow(10, - D/(double) Constants.MaxD));
        }
    }
}
