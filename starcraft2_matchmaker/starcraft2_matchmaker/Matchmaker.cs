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
            if (core.MatchType.Equals(Constants.V3))
            {
                countPlayers = Constants.TotalPlayers_V3;
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
            else if (core.MatchType.Equals(Constants.V3))
            {
                teams = computeMatch(Constants.TeamPlayers_V3, Constants.TeamNumber_V3);
            }
            else if (core.MatchType.Equals(Constants.V4))
            {
                teams = computeMatch(Constants.TeamPlayers_V4, Constants.TeamNumber_V4);
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
                int maxEloTemp = 0;
                int secondEloTemp = 0;
                Team bestTeamTemp = null;
                Team secondTeamTemp = null;
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
                    if (scores[j] >= maxEloTemp)
                    {
                        secondTeamTemp = bestTeamTemp;
                        bestTeamTemp = tempTeams[j];
                        secondEloTemp = maxEloTemp;
                        maxEloTemp = scores[j];
                    }
                    else if (scores[j] >= secondEloTemp)
                    {
                        secondTeamTemp = tempTeams[j];
                        secondEloTemp = scores[j];
                    }
                }
                double tempScore = Statistics.StdDev(scores);
                if (tempScore < score||(i==0))
                {
                    score = tempScore;
                    teams.Clear();
                    for (int j = 0; j < teamNumber; j++)
                    {
                        if (tempTeams[j].Equals(bestTeamTemp))
                        {
                            tempTeams[j].EloAdv = secondEloTemp;
                        }
                        else
                        {
                            tempTeams[j].EloAdv = maxEloTemp;
                        }
                        teams.Add(tempTeams[j].getCopy());
                    }
                }
            }
            return teams;
        }
    }
}
