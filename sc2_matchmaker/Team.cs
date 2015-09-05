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
    public class Team
    {
        Dictionary<string, Player> members = new Dictionary<string, Player>();
        Dictionary<string, int> selectedRace = new Dictionary<string, int>();
        int eloTeam;
        int eloAdv;

        public int EloTeam
        {
            get
            {
                return eloTeam;
            }

            set
            {
                eloTeam = value;
            }
        }

        public int EloAdv
        {
            get
            {
                return eloAdv;
            }

            set
            {
                eloAdv = value;
            }
        }

        public void addMember(Player player)
        {
            members.Add(player.Name, player);
        }

        public void addMember(Player player, int race)
        {
            addMember(player);
            setRace(player, race);
        }

        public void RemoveMember(Player player)
        {
            members.Remove(player.Name);
            selectedRace.Remove(player.Name);
        }

        public void setRace(Player player, int race)
        {
            selectedRace[player.Name]= race;
        }

        public int computeEloTeam()
        {
            EloTeam = 0;
            foreach(var member in members.Values)
            {
                EloTeam += member.Elo[selectedRace[member.Name]];
            }
            EloTeam /= members.Count;
            return EloTeam;
        }

        public void computeNewEloPlayers(bool victory, int teamNumber)
        {
            foreach (var member in members.Values)
            {
                Elo.compute(victory, member, selectedRace[member.Name], eloTeam, eloAdv, teamNumber);
            }
        }

        public Team getCopy()
        {
            Team copy = new Team();
            foreach (var player in members.Values)
            {
                copy.addMember(player, selectedRace[player.Name]);
            }
            copy.EloTeam=eloTeam;
            copy.EloAdv = eloAdv;
            return copy;
        }

        override
        public String ToString()
        {
            string str="";
            foreach (var player in members.Values)
            {
                str += player.Name + " ("+Constants.raceToString(selectedRace[player.Name])+") "+Environment.NewLine;
            }
            str += "Score: " + computeEloTeam();
            return str;
        }

        public int Count
        {
            get
            {
                return members.Count;
            }
            
        }
    }
}
