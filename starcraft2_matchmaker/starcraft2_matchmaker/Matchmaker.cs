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
        }

        public List<Team> computeTeams()
        {
            List<Team> teams = new List<Team>();
            if (core.MatchType.Equals(Constants.FFA))
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
            Score = 0;
            double[] scores = new double[core.CheckedHumanPlayers.Count];
            foreach(var player in core.CheckedHumanPlayers.Values)
            {
                Team tempTeam = new Team();
                tempTeam.addMember(player);
                tempTeams.Add(player.Name, tempTeam);
            }
            for (int i=0; i<Constants.Iterations; i++)
            {
                int j = 0;
                foreach (var player in core.CheckedHumanPlayers.Values)
                {
                    tempTeams[player.Name].setRace(player,player.selectRaceRandomly(rnd));
                    scores[j] = tempTeams[player.Name].computeScore();   
                }
                if (i == 0)
                {
                    Score = Statistics.StdDev(scores);
                    teams.Clear();
                    foreach (var player in core.CheckedHumanPlayers.Values)
                    {
                        teams.Add(tempTeams[player.Name].getCopy());

                    }
                }
                else
                {
                    double tempScore = Statistics.StdDev(scores);
                    if (tempScore < Score)
                    {
                        teams.Clear();
                        foreach (var player in core.CheckedHumanPlayers.Values)
                        {
                            teams.Add(tempTeams[player.Name].getCopy());
                        }
                    }
                }
            }
            return teams;
        }
    }
}
