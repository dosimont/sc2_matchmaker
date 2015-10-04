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

namespace sc2_matchmaker
{
    public class Player : IComparable
    {
        private string name;
        private int[] elo = new int[Constants.RaceNumber];
        private int[] victory = new int[Constants.RaceNumber];
        private int[] defeat = new int[Constants.RaceNumber];
        private bool[] races = new bool[Constants.RaceNumber];


        public Player(string name, bool terran, bool zerg, bool protoss, bool random)
        {
            this.name = name;
            for (int i=0;i< Constants.RaceNumber; i++)
            {
                victory[i] = 0;
                defeat[i] = 0;
                elo[i] = Constants.EloUnranked;
            }
            this.races[Constants.Terran] = terran;
            this.races[Constants.Zerg] = zerg;
            this.races[Constants.Protoss] = protoss;
            this.races[Constants.Random] = random;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int[] Elo
        {
            get
            {
                return elo;
            }

            set
            {
                elo = value;
            }
        }

        public int[] Victory
        {
            get
            {
                return victory;
            }

            set
            {
                victory = value;
            }
        }

        public int[] Defeat
        {
            get
            {
                return defeat;
            }

            set
            {
                defeat = value;
            }
        }

        public bool[] Races
        {
            get
            {
                return races;
            }

            set
            {
                races = value;
            }
        }

        override
        public string ToString()
        {
            return name;
        }

        public void raceMask(bool terran, bool zerg, bool protoss, bool random)
        {
            this.races[Constants.Terran] = terran;
            this.races[Constants.Zerg] = zerg;
            this.races[Constants.Protoss] = protoss;
            this.races[Constants.Random] = random;
        }

        public int selectRaceRandomly(Random rnd)
        {
            int selectedRace;
            do
            {
                selectedRace = rnd.Next(Constants.RaceNumber);
            }
            while (!this.races[selectedRace]);
            return selectedRace;
        }

        public void reset()
        {
            for (int i = 0; i < Constants.RaceNumber; i++)
            {
                victory[i] = 0;
                defeat[i] = 0;
                elo[i] = Constants.EloUnranked;
            }
        }

        public bool hasBeenPlayed(int race)
        {
            if ((defeat[race] != 0) || (victory[race] != 0)){
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getOverallVictory()
        {
            int temp = 0;
            for (int i = 0; i < Constants.RaceNumber; i++)
            {
                if (hasBeenPlayed(i))
                {
                    temp += victory[i];
                }
            }
            return temp;
        }

        public int getOverallDefeat()
        {
            int temp = 0;
            for (int i = 0; i < Constants.RaceNumber; i++)
            {
                if (hasBeenPlayed(i))
                {
                    temp += defeat[i];
                }
            }
            return temp;
        }

        public int getOverallElo()
        {
            int temp = 0;
            int count = 0;
            for (int i = 0; i < Constants.RaceNumber; i++)
            {
                if (hasBeenPlayed(i))
                {
                    temp += elo[i];
                    count++;
                }
            }
            return temp/count;
        }

        public int CompareTo(object obj)
        {
            if (this.getOverallElo() < ((Player)(obj)).getOverallElo())
                return 1;
            if (this.getOverallElo() > ((Player)(obj)).getOverallElo())
                return -1;
            if (this.getOverallElo() == ((Player)(obj)).getOverallElo() && this.getOverallVictory() > ((Player)(obj)).getOverallVictory())
                return -1;
            if (this.getOverallElo() == ((Player)(obj)).getOverallElo() && this.getOverallVictory() < ((Player)(obj)).getOverallVictory())
                return 1;
            return 0;
        }
    }
}
