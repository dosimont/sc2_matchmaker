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

        public Matchmaker(Core core)
        {
            this.core = core;
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
            List<Team> teams = new List<Team>();
            Dictionary<String, Dictionary<int, Team>> teamsAndRaces = new Dictionary<String, Dictionary<int, Team>>();
            foreach (var player in core.CheckedHumanPlayers.Values)
            {
                teamsAndRaces.Add(player.Name, new Dictionary<int, Team>());
                Dictionary<int, List<int>> doubles = new Dictionary<int, List<int>>();
                for (int i = 0; i < Constants.RaceNumber; i++)
                {
                    List<int> tempList = new List<int>();
                    tempList.Add(i);
                    doubles.Add(i, tempList);
                }
                for (int i = 0; i < Constants.RaceNumber; i++)
                {
                    if (player.Races[i])
                    {
                        Team team = new Team();
                        team.addMember(player);
                        team.setRace(player, i);
                        team.computeScore();
                        teamsAndRaces[player.Name].Add(i, team);
                        for (int j = 0; j < i; j++)
                        {
                            if (player.Races[j])
                            {
                                if ((teamsAndRaces[player.Name])[j].Score == team.Score)
                                {
                                    doubles.Remove(i);
                                    doubles[j].Add(i);
                                }
                            }
                        }
                    }

                }
                Random rnd = new Random();
                foreach (var i in doubles.Keys)
                {
                    int selected = i;
                    do
                    {
                        selected = rnd.Next(i, doubles[i][doubles[i].Count - 1]);
                    } while (!doubles[i].Contains(selected));
                    foreach (var j in doubles[i])
                    {
                        if (j != selected)
                        {
                            teamsAndRaces[player.Name].Remove(j);
                        }
                    }
                }
            }
            Dictionary<String, Team> bestTeams = new Dictionary<String, Team>();
            foreach (var playerName in teamsAndRaces.Keys)
            {
                //foreach (var i in teamsAndRaces[playerName].Keys)
                //continuer ici
                //recursif
            }
            return teams;
        }

    }


}
