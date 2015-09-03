/*This file is part of SC 2 Matchmaker.

SC 2 Matchmaker is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 3 of the License.

SC 2 Matchmaker is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Foobar.  If not, see<http://www.gnu.org/licenses/>.

Copyright Damien Dosimont, 2015 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sc2_matchmaker
{
    class PlayerSelecter
    {
        List<Player> players;
        List<Player> assignedPlayers=new List<Player>();
        List<Player> nonAssignedPlayers=new List<Player>();
        Random rnd = new Random();

        public PlayerSelecter(List<Player> players)
        {
            this.players = players;
            reset();
        }

        public void reset()
        {
            nonAssignedPlayers.Clear();
            foreach(var player in players)
            {
                nonAssignedPlayers.Add(player);
                assignedPlayers.Clear();
            }
        }

        public Player getRandomPlayer()
        {
            Player player = null;
            if (nonAssignedPlayers.Count > 0)
            {
                int index = rnd.Next(nonAssignedPlayers.Count);
                player = nonAssignedPlayers[index];
                nonAssignedPlayers.Remove(player);
                assignedPlayers.Add(player);
            }
            return player;
        }

        public Player getNextPlayer()
        {
            Player player = null;
            if (nonAssignedPlayers.Count > 0)
            {
                int index = 0;
                player = nonAssignedPlayers[index];
                nonAssignedPlayers.Remove(player);
                assignedPlayers.Add(player);
            }
            return player;
        }


    }
}
