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

        public void checkMatch()
        {
            if (core.CheckedHumanPlayers.Count < 2)
            {
                throw new Exception("Not enough players");
            }
            int countPlayers=0;
            if (core.MatchType.Equals(Constants.FFA))
            {
                return;
            }
            if (core.MatchType.Equals(Constants.V1))
            {
                countPlayers = Constants.TotalPlayers_V1;
            }
            if (core.MatchType.Equals(Constants.V2))
            {
                countPlayers = Constants.TotalPlayers_V2;
            }
            if (core.MatchType.Equals(Constants.V22))
            {
                countPlayers = Constants.TotalPlayers_V22;
            }
            if (core.MatchType.Equals(Constants.V222))
            {
                countPlayers = Constants.TotalPlayers_V222;
            }
            if (core.MatchType.Equals(Constants.V3))
            {
                countPlayers = Constants.TotalPlayers_V3;
            }
            if (core.MatchType.Equals(Constants.V33))
            {
                countPlayers = Constants.TotalPlayers_V33;
            }
            if (core.MatchType.Equals(Constants.V4))
            {
                countPlayers = Constants.TotalPlayers_V4;
            }
            if (core.CheckedHumanPlayers.Count != countPlayers)
            {
                throw new Exception("You must select exactly " + countPlayers + " players");
            }
        }

        public List<Team> computeTeams()
        {
            List<Team> teams = new List<Team>();
            if (core.MatchType.Equals(Constants.FFA)||core.MatchType.Equals(Constants.V1))
            {
                teams = computeMatch(Constants.TeamPlayers_FFA, core.CheckedHumanPlayers.Count);
            }
            else if (core.MatchType.Equals(Constants.V2))
            {
                teams = computeMatch(Constants.TeamPlayers_V2, Constants.TeamNumber_V2);
            }
            else if (core.MatchType.Equals(Constants.V22))
            {
                teams = computeMatch(Constants.TeamPlayers_V22, Constants.TeamNumber_V22);
            }
            else if (core.MatchType.Equals(Constants.V222))
            {
                teams = computeMatch(Constants.TeamPlayers_V222, Constants.TeamNumber_V222);
            }
            else if (core.MatchType.Equals(Constants.V3))
            {
                teams = computeMatch(Constants.TeamPlayers_V3, Constants.TeamNumber_V3);
            }
            else if (core.MatchType.Equals(Constants.V33))
            {
                teams = computeMatch(Constants.TeamPlayers_V33, Constants.TeamNumber_V33);
            }
            else if (core.MatchType.Equals(Constants.V4))
            {
                teams = computeMatch(Constants.TeamPlayers_V4, Constants.TeamNumber_V4);
            }
            return teams;
        }


        private List<Team> computeMatch(int teamMemberNumber, int teamNumber)
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
                        tempTeams[j].EloAdv = scores.Sum()-tempTeams[j].EloTeam/(teamNumber-1);
                        teams.Add(tempTeams[j].getCopy());
                    }
                }
            }
            return teams;
        }
    }
}
