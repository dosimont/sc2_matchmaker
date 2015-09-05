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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace sc2_matchmaker
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
