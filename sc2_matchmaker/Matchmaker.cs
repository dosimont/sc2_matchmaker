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
    class Matchmaker
    {
        private Core core;
        double score;

        public Matchmaker(Core core)
        {
            this.core = core;
        }

        public double Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        public List<Team> computeMatch()
        {
            List<Team> teams = new List<Team>();
            teams = computeTeams(core.getExpectedTeamPlayerNumber(), core.getExpectedTeamNumber());
            return teams;
        }

        public void computeMatch(List<Team> teams)
        {
            score = 0;
            int[] scores = new int[teams.Count];
            for (int i = 0; i < teams.Count; i++)
            {
                scores[i] = teams[i].computeEloTeam();
            }
            score = Statistics.StdDev(scores);
            for (int j = 0; j <  teams.Count; j++)
            {
                teams[j].EloAdv = (scores.Sum() - teams[j].EloTeam) / (teams.Count - 1);
            }
        }


        private List<Team> computeTeams(int teamMemberNumber, int teamNumber)
        {
            Random rnd = new Random();
            List<Team> teams = new List<Team>();
            List<Team> tempTeams = new List<Team>();
            PlayerSelecter playerSelecter = new PlayerSelecter(core.CheckedHumanPlayers.Values.ToList());
            score = 0;
            int[] scores = new int[teamNumber];
            for (int i = 0; i < Constants.Iterations; i++)
            {
                tempTeams.Clear();
                playerSelecter.reset();
                for (int j = 0; j < teamNumber; j++)
                {
                    tempTeams.Add(new Team());
                }
                for (int j = 0; j < teamMemberNumber; j++)
                {
                    for (int k = 0; k < teamNumber; k++)
                    {
                        Player player;
                        if (teamMemberNumber == 1)
                        {
                            player = playerSelecter.getNextPlayer();
                        }
                        else
                        {
                            player = playerSelecter.getRandomPlayer();
                            
                        }
                        tempTeams[k].addMember(player, player.selectRaceRandomly(rnd));
                    }
                }
                for (int j = 0; j < teamNumber; j++)
                {
                    scores[j] = tempTeams[j].computeEloTeam();
                }
                double tempScore = Statistics.StdDev(scores);
                if (tempScore < score||(i==0))
                {
                    score = tempScore;
                    teams.Clear();
                    for (int j = 0; j < teamNumber; j++)
                    {
                        tempTeams[j].EloAdv = (scores.Sum()-tempTeams[j].EloTeam)/(teamNumber-1);
                        teams.Add(tempTeams[j].getCopy());
                    }
                }
            }
            return teams;
        }
    }
}
