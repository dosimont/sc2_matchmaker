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

        public void addMember(Player player)
        {
            members.Add(player.Name, player);
        }

        public void setRace(Player player, int race)
        {
            selectedRace.Add(player.Name, race);
        }
        public double computeScore()
        {
            Score = members.Count * Constants.CountFactor;
            foreach(var member in members.Values)
            {
                Score += member.Score[selectedRace[member.Name]];
            }
            return Score;
        }

    }
}
