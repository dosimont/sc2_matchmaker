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

        public void computeNewEloPlayers(bool victory)
        {
            foreach (var member in members.Values)
            {
                Elo.compute(victory, member, selectedRace[member.Name], eloTeam, eloAdv);
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
                str += player.Name + " (";
                String race = "";
                switch (selectedRace[player.Name])
                {
                    case Constants.Terran:
                        race = "Terran";
                        break;
                    case Constants.Zerg:
                        race = "Zerg";
                        break;
                    case Constants.Protoss:
                        race = "Protoss";
                        break;
                    case Constants.Random:
                        race = "Random";
                        break;
                    default:
                        race = "Unknown";
                        break; 
                }
                   str+= race+") "+Environment.NewLine;
            }
            str+="Score:" +computeEloTeam();
            return str;
        }
    }
}
