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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sc2_matchmaker
{
    class Core
    {
        private Dictionary<string, Player> humanPlayers;
        private Dictionary<string, Player> checkedHumanPlayers;
        private List<Player> ranks;
        private List<Team> currentTeams;
        private string currentFile;
        private string matchType;
        private double currentScore;

        internal Dictionary<string, Player> HumanPlayers
        {
            get
            {
                return humanPlayers;
            }

            set
            {
                humanPlayers = value;
            }
        }

        public string CurrentFile
        {
            get
            {
                return currentFile;
            }

            set
            {
                currentFile = value;
            }
        }

        public Dictionary<string, Player> CheckedHumanPlayers
        {
            get
            {
                return checkedHumanPlayers;
            }

            set
            {
                checkedHumanPlayers = value;
            }
        }

        public string MatchType
        {
            get
            {
                return matchType;
            }

            set
            {
                matchType = value;
            }
        }

        public List<Team> CurrentTeams
        {
            get
            {
                return currentTeams;
            }

            set
            {
                currentTeams = value;
            }
        }

        public double CurrentScore
        {
            get
            {
                return currentScore;
            }

            set
            {
                currentScore = value;
            }
        }

        public List<Player> Ranks
        {
            get
            {
                return ranks;
            }

            set
            {
                ranks = value;
            }
        }

        public Core()
        {
            HumanPlayers = new Dictionary<string, Player>();
        }

        public Core(string currentFile)
        {
            this.CurrentFile = currentFile;
            HumanPlayers = new Dictionary<string, Player>();
        }

        public void addPlayer(string name, bool terran, bool zerg, bool protoss, bool random)
        {
            HumanPlayers.Add(name, new Player(name, terran, zerg, protoss, random));
            computeRanks();
        }

        public void removePlayer(string name)
        {
            HumanPlayers.Remove(name);
            computeRanks();
        }

        public void modifyPlayer(Player player, string newname, bool terran, bool zerg, bool protoss, bool random)
        {
            HumanPlayers.Remove(player.Name);
            player.Name = newname;
            player.raceMask(terran, zerg, protoss, random);
            HumanPlayers.Add(newname, player);
            computeRanks();
        }

        public void savePlayers()
        {
            PlayerWriter playerWriter = new PlayerWriter(currentFile);
            playerWriter.writePlayers(humanPlayers.Values.ToList());
        }

        public void openPlayers()
        {
            PlayerReader playerReader = new PlayerReader(currentFile);
            HumanPlayers = playerReader.readPlayers();
        }
        public void computeMatchmaking(Constants.MatchPolicy policy)
        {
            Matchmaker matchMaker = new Matchmaker(this);
            checkMatch();
            CurrentTeams = matchMaker.computeMatch(policy);
            CurrentScore = matchMaker.Score;
        }

        public void computeMatchmaking(List<Team> team)
        {
            Matchmaker matchMaker = new Matchmaker(this);
            CurrentTeams = team;
            matchMaker.computeMatch(team);
            CurrentScore = matchMaker.Score;
        }

        public void winningTeam(int index)
        {
            for (int i = 0; i < currentTeams.Count; i++)
            {
                currentTeams[i].computeNewEloPlayers(i == index, currentTeams.Count);

            }
        }

        public void addPlayer(string name, bool terran, bool zerg, bool protoss, bool random, string terranLvl, string zergLvl, string protossLvl, string randomLvl)
        {
            HumanPlayers.Add(name, new Player(name, terran, zerg, protoss, random));
            if (terranLvl.Equals(Constants.Unranked))
            {
                HumanPlayers[name].Elo[Constants.Terran] = Constants.EloUnranked;
            }
            else if (terranLvl.Equals(Constants.Bronze))
            {
                HumanPlayers[name].Elo[Constants.Terran] = Constants.EloBronze;
            }
            else if (terranLvl.Equals(Constants.Silver))
            {
                HumanPlayers[name].Elo[Constants.Terran] = Constants.EloSilver;
            }
            else if (terranLvl.Equals(Constants.Gold))
            {
                HumanPlayers[name].Elo[Constants.Terran] = Constants.EloGold;
            }
            else if (terranLvl.Equals(Constants.Platine))
            {
                HumanPlayers[name].Elo[Constants.Terran] = Constants.EloPlatine;
            }
            else if (terranLvl.Equals(Constants.Diamond))
            {
                HumanPlayers[name].Elo[Constants.Terran] = Constants.EloDiamond;
            }
            else if (terranLvl.Equals(Constants.Master))
            {
                HumanPlayers[name].Elo[Constants.Terran] = Constants.EloMaster;
            }
            else if (terranLvl.Equals(Constants.GrandMaster))
            {
                HumanPlayers[name].Elo[Constants.Terran] = Constants.EloGrandMaster;
            }
            if (zergLvl.Equals(Constants.Unranked))
            {
                HumanPlayers[name].Elo[Constants.Zerg] = Constants.EloUnranked;
            }
            else if (zergLvl.Equals(Constants.Bronze))
            {
                HumanPlayers[name].Elo[Constants.Zerg] = Constants.EloBronze;
            }
            else if (zergLvl.Equals(Constants.Silver))
            {
                HumanPlayers[name].Elo[Constants.Zerg] = Constants.EloSilver;
            }
            else if (zergLvl.Equals(Constants.Gold))
            {
                HumanPlayers[name].Elo[Constants.Zerg] = Constants.EloGold;
            }
            else if (zergLvl.Equals(Constants.Platine))
            {
                HumanPlayers[name].Elo[Constants.Zerg] = Constants.EloPlatine;
            }
            else if (zergLvl.Equals(Constants.Diamond))
            {
                HumanPlayers[name].Elo[Constants.Zerg] = Constants.EloDiamond;
            }
            else if (zergLvl.Equals(Constants.Master))
            {
                HumanPlayers[name].Elo[Constants.Zerg] = Constants.EloMaster;
            }
            else if (zergLvl.Equals(Constants.GrandMaster))
            {
                HumanPlayers[name].Elo[Constants.Zerg] = Constants.EloGrandMaster;
            }
            if (protossLvl.Equals(Constants.Unranked))
            {
                HumanPlayers[name].Elo[Constants.Protoss] = Constants.EloUnranked;
            }
            else if (protossLvl.Equals(Constants.Bronze))
            {
                HumanPlayers[name].Elo[Constants.Protoss] = Constants.EloBronze;
            }
            else if (protossLvl.Equals(Constants.Silver))
            {
                HumanPlayers[name].Elo[Constants.Protoss] = Constants.EloSilver;
            }
            else if (protossLvl.Equals(Constants.Gold))
            {
                HumanPlayers[name].Elo[Constants.Protoss] = Constants.EloGold;
            }
            else if (protossLvl.Equals(Constants.Platine))
            {
                HumanPlayers[name].Elo[Constants.Protoss] = Constants.EloPlatine;
            }
            else if (protossLvl.Equals(Constants.Diamond))
            {
                HumanPlayers[name].Elo[Constants.Protoss] = Constants.EloDiamond;
            }
            else if (protossLvl.Equals(Constants.Master))
            {
                HumanPlayers[name].Elo[Constants.Protoss] = Constants.EloMaster;
            }
            else if (protossLvl.Equals(Constants.GrandMaster))
            {
                HumanPlayers[name].Elo[Constants.Protoss] = Constants.EloGrandMaster;
            }
            if (randomLvl.Equals(Constants.Unranked))
            {
                HumanPlayers[name].Elo[Constants.Random] = Constants.EloUnranked;
            }
            else if (randomLvl.Equals(Constants.Bronze))
            {
                HumanPlayers[name].Elo[Constants.Random] = Constants.EloBronze;
            }
            else if (randomLvl.Equals(Constants.Silver))
            {
                HumanPlayers[name].Elo[Constants.Random] = Constants.EloSilver;
            }
            else if (randomLvl.Equals(Constants.Gold))
            {
                HumanPlayers[name].Elo[Constants.Random] = Constants.EloGold;
            }
            else if (randomLvl.Equals(Constants.Platine))
            {
                HumanPlayers[name].Elo[Constants.Random] = Constants.EloPlatine;
            }
            else if (randomLvl.Equals(Constants.Diamond))
            {
                HumanPlayers[name].Elo[Constants.Random] = Constants.EloDiamond;
            }
            else if (randomLvl.Equals(Constants.Master))
            {
                HumanPlayers[name].Elo[Constants.Random] = Constants.EloMaster;
            }
            else if (randomLvl.Equals(Constants.GrandMaster))
            {
                HumanPlayers[name].Elo[Constants.Random] = Constants.EloGrandMaster;
            }
        }

        public void computeRanks()
        {
            Ranks = humanPlayers.Values.ToList();
            Ranks.Sort();
        }

        public int getRank(Player player)
        {
            return Ranks.IndexOf(player)+1;
        }

        public void checkMatch()
        {
            if (CheckedHumanPlayers.Count < 2)
            {
                throw new Exception("Not enough players");
            }
            int countPlayers = 0;
            if (MatchType.Equals(Constants.FFA))
            {
                return;
            }
            if (MatchType.Equals(Constants.V1))
            {
                countPlayers = Constants.TotalPlayers_V1;
            }
            if (MatchType.Equals(Constants.V2))
            {
                countPlayers = Constants.TotalPlayers_V2;
            }
            if (MatchType.Equals(Constants.V22))
            {
                countPlayers = Constants.TotalPlayers_V22;
            }
            if (MatchType.Equals(Constants.V222))
            {
                countPlayers = Constants.TotalPlayers_V222;
            }
            if (MatchType.Equals(Constants.V3))
            {
                countPlayers = Constants.TotalPlayers_V3;
            }
            if (MatchType.Equals(Constants.V33))
            {
                countPlayers = Constants.TotalPlayers_V33;
            }
            if (MatchType.Equals(Constants.V4))
            {
                countPlayers = Constants.TotalPlayers_V4;
            }
            if (CheckedHumanPlayers.Count != countPlayers)
            {
                throw new Exception("You must select exactly " + countPlayers + " players");
            }
        }

        public int getExpectedTeamNumber()
        {
            if (MatchType.Equals(Constants.FFA) || MatchType.Equals(Constants.V1))
            {
                return (CheckedHumanPlayers.Count);
            }
            else if (MatchType.Equals(Constants.V2))
            {
                return Constants.TeamNumber_V2;
            }
            else if (MatchType.Equals(Constants.V22))
            {
                return Constants.TeamNumber_V22;
            }
            else if (MatchType.Equals(Constants.V222))
            {
                return Constants.TeamNumber_V222;
            }
            else if (MatchType.Equals(Constants.V3))
            {
                return Constants.TeamNumber_V3;
            }
            else if (MatchType.Equals(Constants.V33))
            {
                return Constants.TeamNumber_V33;
            }
            else if (MatchType.Equals(Constants.V4))
            {
                return Constants.TeamNumber_V4;
            }
            return -1;
        }

        public int getExpectedTeamPlayerNumber()
        {
            if (MatchType.Equals(Constants.FFA) || MatchType.Equals(Constants.V1))
            {
                return Constants.TeamPlayers_FFA;
            }
            else if (MatchType.Equals(Constants.V2))
            {
                return Constants.TeamPlayers_V2;
            }
            else if (MatchType.Equals(Constants.V22))
            {
                return Constants.TeamPlayers_V22;
            }
            else if (MatchType.Equals(Constants.V222))
            {
                return Constants.TeamPlayers_V222;
            }
            else if (MatchType.Equals(Constants.V3))
            {
                return Constants.TeamPlayers_V3;
            }
            else if (MatchType.Equals(Constants.V33))
            {
                return Constants.TeamPlayers_V33;
            }
            else if (MatchType.Equals(Constants.V4))
            {
                return Constants.TeamPlayers_V4;
            }
            return -1;
        }

        public void Export(string file)
        {
            MarkdownExporter mkExporter = new MarkdownExporter(file, this);
            mkExporter.write();
        }
    }
}
