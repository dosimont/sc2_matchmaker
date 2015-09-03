using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starcraft2_matchmaker
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
            if (core.MatchType.Equals(Constants.FFA))
            {
            }
            if (core.MatchType.Equals(Constants.V1) && core.CheckedHumanPlayers.Count != 2)
            { 
                throw new Exception("Too many players");
            }
        }

        public List<Team> computeTeams()
        {
            List<Team> teams = new List<Team>();
            if (core.MatchType.Equals(Constants.FFA)|| core.MatchType.Equals(Constants.V1))
            {
                teams = computeFFA();
            }


            return teams;
        }

        private List<Team> computeFFA()
        {
            Random rnd = new Random();
            List<Team> teams = new List<Team>();
            Dictionary<String,Team> tempTeams = new Dictionary<String,Team>();
            score = 0;
            int maxElo=Constants.StartElo;
            int secondElo = Constants.StartElo;
            Team bestTeam=null;
            Team secondTeam=null;
            int[] scores = new int[core.CheckedHumanPlayers.Count];
            foreach(var player in core.CheckedHumanPlayers.Values)
            {
                Team tempTeam = new Team();
                tempTeam.addMember(player);
                tempTeams.Add(player.Name, tempTeam);
            }
            for (int i = 0; i<Constants.Iterations; i++)
            {
                int j = 0;
                foreach (var player in core.CheckedHumanPlayers.Values)
                {
                    tempTeams[player.Name].setRace(player,player.selectRaceRandomly(rnd));
                    scores[j] = tempTeams[player.Name].computeEloTeam();
                    if (scores[j]>= maxElo)
                    {
                        secondTeam = bestTeam;
                        bestTeam = tempTeams[player.Name];
                        secondElo = maxElo;
                        maxElo = scores[j];
                    }
                    else if (scores[j] >= secondElo)
                    {
                        secondTeam = tempTeams[player.Name];
                        secondElo = scores[j];
                    }
                    j++;
                }
                if (i == 0)
                {
                    score = Statistics.StdDev(scores);
                    teams.Clear();
                    foreach (var player in core.CheckedHumanPlayers.Values)
                    {
                        if (tempTeams[player.Name].Equals(bestTeam))
                        {
                            tempTeams[player.Name].EloAdv = secondElo;
                        }
                        else
                        {
                            tempTeams[player.Name].EloAdv = maxElo;
                        }
                        teams.Add(tempTeams[player.Name].getCopy());
                    }
                }
                else
                {
                    double tempScore = Statistics.StdDev(scores);
                    if (tempScore < score)
                    {
                        score = tempScore;
                        teams.Clear();
                        foreach (var player in core.CheckedHumanPlayers.Values)
                        {
                            if (tempTeams[player.Name].Equals(bestTeam))
                            {
                                tempTeams[player.Name].EloAdv = secondElo;
                            }
                            else
                            {
                                tempTeams[player.Name].EloAdv = maxElo;
                            }
                             teams.Add(tempTeams[player.Name].getCopy());
                        }
                    }
                }
            }
            return teams;
        }
    }
}
