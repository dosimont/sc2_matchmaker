﻿/*This file is part of SC 2 Matchmaker.

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
    class Constants
    {
        public const int RaceNumber = 4;
        public const int Terran = 0;
        public const int Zerg = 1;
        public const int Protoss = 2;
        public const int Random = 3;

        public const string FFA = "Free For All";
        public const string BAL = "Balanced";
        public const string V1 = "1v1";
        public const string V2 = "2v2";
        public const string V3 = "3v3";
        public const string V4 = "4v4";
        public const string V22 = "2v2v2";
        public const string V222 = "2v2v2v2";
        public const string V33 = "3v3v3";

        public const int TotalPlayers_FFA = -1;
        public const int TotalPlayers_BAL = -1;
        public const int TotalPlayers_V1 = 2;
        public const int TotalPlayers_V2 = 4;
        public const int TotalPlayers_V3 = 6;
        public const int TotalPlayers_V4 = 8;
        public const int TotalPlayers_V22 = 6;
        public const int TotalPlayers_V222 = 8;
        public const int TotalPlayers_V33 = 9;

        public const int TeamPlayers_FFA = 1;
        public const int TeamPlayers_BAL = -1;
        public const int TeamPlayers_V2 = 2;
        public const int TeamPlayers_V3 = 3;
        public const int TeamPlayers_V4 = 4;
        public const int TeamPlayers_V22 = 2;
        public const int TeamPlayers_V222 = 2;
        public const int TeamPlayers_V33 = 3;

        public const int TeamNumber_V1 = 2;
        public const int TeamNumber_V2 = 2;
        public const int TeamNumber_V3 = 2;
        public const int TeamNumber_V4 = 2;
        public const int TeamNumber_V22 = 3;
        public const int TeamNumber_V222 = 4;
        public const int TeamNumber_V33 = 2;

        public const int FName = 0;
        public const int FBoolTerran = 1;
        public const int FVictoryTerran = 2;
        public const int FDefeatTerran = 3;
        public const int FEloTerran = 4;
        public const int FBoolZerg = 5;
        public const int FVictoryZerg = 6;
        public const int FDefeatZerg = 7;
        public const int FEloZerg = 8;
        public const int FBoolProtoss = 9;
        public const int FVictoryProtoss = 10;
        public const int FDefeatProtoss = 11;
        public const int FEloProtoss = 12;
        public const int FBoolRandom = 13;
        public const int FVictoryRandom = 14;
        public const int FDefeatRandom = 15;
        public const int FEloRandom = 16;

        public const int CountFactor = 0;

        public const int Iterations = 100000;

        public const int K1 = 40;
        public const int K2 = 20;
        public const int K3 = 10;

        public const int K1seuil_games = 30;
        public const int K2seuil_elo = 2400;

        public const int WVictory = 1;
        public const int WDefeat = 0;

        public const int MaxD = 400;

        public const int EloUnranked = 1000;
        public const int EloBronze = 1200;
        public const int EloSilver = 1400;
        public const int EloGold = 1600;
        public const int EloPlatine = 1800;
        public const int EloDiamond = 2000;
        public const int EloMaster = 2200;
        public const int EloGrandMaster = 2400;

        public const string Unranked = "Unranked";
        public const string Bronze = "Bronze";
        public const string Silver = "Silver";
        public const string Gold = "Gold";
        public const string Platine = "Platinum";
        public const string Diamond = "Diamond";
        public const string Master = "Master";
        public const string GrandMaster = "GrandMaster";

        public static string raceToString(int race)
        {
            string raceStr;
            switch (race)
            {
                case Constants.Terran:
                    raceStr = "Terran";
                    break;
                case Constants.Zerg:
                    raceStr = "Zerg";
                    break;
                case Constants.Protoss:
                    raceStr = "Protoss";
                    break;
                case Constants.Random:
                    raceStr = "Random";
                    break;
                default:
                    raceStr = "Unknown";
                    break;
            }
            return raceStr;
        }

        public enum MatchPolicy {
            Min, Max, Balanced, Random, Manual
        };
    }
}
