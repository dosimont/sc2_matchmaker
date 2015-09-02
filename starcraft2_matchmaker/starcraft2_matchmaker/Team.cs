using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starcraft2_matchmaker
{
    public class Team
    {
        Dictionary<string, Player> members = new Dictionary<string, Player>();
        Dictionary<string, int> selectedRace = new Dictionary<string, int>();
        double score=0;

        public double Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        public void addVictory()
        {
            foreach (var member in members.Values)
            {
                member.Victory[selectedRace[member.Name]]++;
            }
        }

        public void addDefeat()
        {
            foreach (var member in members.Values)
            {
                member.Defeat[selectedRace[member.Name]]++;
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
        public double computeScore()
        {
            Score = members.Count * Constants.CountFactor;
            foreach(var member in members.Values)
            {
                Score += (double) member.Score[selectedRace[member.Name]];
            }
            Score /= members.Count;
            return Score;
        }

        public Team getCopy()
        {
            Team copy = new Team();
            foreach (var player in members.Values)
            {
                copy.addMember(player, selectedRace[player.Name]);
            }
            copy.computeScore();
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
            str+="Score:" +computeScore();
            return str;
        }
    }
}
