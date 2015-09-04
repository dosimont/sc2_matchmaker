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
