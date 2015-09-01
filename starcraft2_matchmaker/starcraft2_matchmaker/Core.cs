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
        Dictionary<string, Player> humanPlayers;
        private string currentFile;

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

        public void addPlayerVictory(string name, int race)
        {
            if (race < Constants.RaceNumber && race > 0)
            {
                if (HumanPlayers.ContainsKey(name))
                {
                    HumanPlayers[name].Victory[race] += 1;
                }
            }
        }

        public void addPlayerDefeat(string name, int race)
        {
            if (race < Constants.RaceNumber && race > 0)
            {
                if (HumanPlayers.ContainsKey(name))
                {
                    HumanPlayers[name].Defeat[race] += 1;
                }
            }
        }

        public void computeScores()
        {
            for (int i=0; i<Constants.RaceNumber; i++)
            {
                foreach (var item in HumanPlayers)
                {
                    if (HumanPlayers[item.Key].Victory[i] == 0)
                    {
                        HumanPlayers[item.Key].Score[i] = 0;
                    }
                    else
                    {
                        HumanPlayers[item.Key].Score[i] = (double)HumanPlayers[item.Key].Victory[i] / (double)(HumanPlayers[item.Key].Victory[i] + HumanPlayers[item.Key].Defeat[i]);
                    }
                }            
            }
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
            computeScores();
        }


    }
}
