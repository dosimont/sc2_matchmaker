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
using System.Threading.Tasks;

namespace sc2_matchmaker
{
    public class PlayerWrapper
    {
        Player player;
        int teamNumber;
        int race;

        public Player Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        public int TeamNumber
        {
            get
            {
                return teamNumber;
            }

            set
            {
                teamNumber = value;
            }
        }

        public int Race
        {
            get
            {
                return race;
            }

            set
            {
                race = value;
            }
        }

        public PlayerWrapper(Player player, int race, int teamNumber){
            this.Player = player;
            this.Race = race;
            this.TeamNumber = teamNumber;
        }

        override
        public string ToString()
        {
            return "Team " + TeamNumber + ": " + Player.Name + " (" + Constants.raceToString(Race) + ")";
        }
    }
}
