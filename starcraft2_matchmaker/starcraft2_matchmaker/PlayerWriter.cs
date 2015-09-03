using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace starcraft2_matchmaker
{
    public class PlayerWriter
    {
        private string file;
        public PlayerWriter(string file)
        {
            this.file = file;
        }
        
        public void writePlayers(List<Player> listPlayers)
        {
            using (CsvFileWriter writer = new CsvFileWriter(file))
            {
                foreach (var item in listPlayers)
                {
                    CsvRow row = new CsvRow();
                    row.Add(item.Name);
                    for (int i = 0; i < Constants.RaceNumber; i++)
                    {
                        row.Add(item.Races[i].ToString());
                        row.Add(item.Victory[i].ToString());
                        row.Add(item.Defeat[i].ToString());
                        row.Add(item.Elo[i].ToString());
                    }
                    writer.WriteRow(row);
                }
            }
        }
    }
}
