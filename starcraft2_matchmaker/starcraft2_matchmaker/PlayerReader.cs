using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starcraft2_matchmaker
{
    class PlayerReader
    {
        private string file;
        public PlayerReader(string file)
        {
            this.file = file;
        }

        public Dictionary<string, Player> readPlayers()
        {
            Dictionary<string, Player> listPlayers = new Dictionary<string, Player>();
            using (CsvFileReader reader = new CsvFileReader(file))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    listPlayers.Add(row[Constants.FName], new Player(row[Constants.FName], boolFromString(row[Constants.FBoolTerran]),
                        boolFromString(row[Constants.FBoolZerg]), boolFromString(row[Constants.FBoolProtoss]), boolFromString(row[Constants.FBoolRandom])));
                    Player temp = listPlayers[row[Constants.FName]];
                    int.TryParse(row[Constants.FVictoryTerran], out temp.Victory[Constants.Terran]);
                    int.TryParse(row[Constants.FVictoryZerg], out temp.Victory[Constants.Zerg]);
                    int.TryParse(row[Constants.FVictoryProtoss], out temp.Victory[Constants.Protoss]);
                    int.TryParse(row[Constants.FVictoryRandom], out temp.Victory[Constants.Random]);
                    int.TryParse(row[Constants.FDefeatTerran], out temp.Defeat[Constants.Terran]);
                    int.TryParse(row[Constants.FDefeatZerg], out temp.Defeat[Constants.Zerg]);
                    int.TryParse(row[Constants.FDefeatProtoss], out temp.Defeat[Constants.Protoss]);
                    int.TryParse(row[Constants.FDefeatRandom], out temp.Defeat[Constants.Random]);
                }
            }
            return listPlayers;
        }

        private bool boolFromString(string b)
        {
            return b.Equals("True");

        }
    }
            
}
