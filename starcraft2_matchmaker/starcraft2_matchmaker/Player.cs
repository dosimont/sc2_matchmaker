using System;

namespace starcraft2_matchmaker
{
    public class Player
    {
        private string name;
        private double[] score = new double[Constants.RaceNumber];
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
                score[i] = 0;
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

        public double[] Score
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
    }
}
