using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starcraft2_matchmaker
{
    class Core
    {
        private Dictionary<string, Player> humanPlayers;
        private Dictionary<string, Player> checkedHumanPlayers;
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
        }

        public void removePlayer(string name)
        {
            HumanPlayers.Remove(name);
        }

        public void modifyPlayer(Player player, string newname, bool terran, bool zerg, bool protoss, bool random)
        {
            HumanPlayers.Remove(player.Name);
            player.Name = newname;
            player.raceMask(terran, zerg, protoss, random);
            HumanPlayers.Add(newname, player);
        }

        public void savePlayers()
        {
            PlayerWriter playerWriter = new PlayerWriter(currentFile);
            playerWriter.writePlayers(humanPlayers.Values.ToList());
        }

        public void openPlayers()
        {
            PlayerReader playerReader = new PlayerReader(currentFile);
            HumanPlayers=playerReader.readPlayers();
        }
        public void computeMatchmaking()
        {
            Matchmaker matchMaker = new Matchmaker(this);
            matchMaker.checkMatch();
            CurrentTeams=matchMaker.computeTeams();
            CurrentScore = matchMaker.Score;
        }

        public void winningTeam(int index)
        {
            for (int i = 0; i < currentTeams.Count; i++)
            {
                currentTeams[i].computeNewEloPlayers(i == index);

            }
        }

    }
}
