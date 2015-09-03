using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starcraft2_matchmaker
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

        public const int TotalMaxPlayers_FFA = -1;
        public const int TotalMaxPlayers_BAL = -1;
        public const int TotalMaxPlayers_V1 = 2;
        public const int TotalMaxPlayers_V2 = 4;
        public const int TotalMaxPlayers_V3 = 6;
        public const int TotalMaxPlayers_V4 = 8;
        public const int TotalMaxPlayers_V22 = 8;

        public const int TeamMaxPlayers_FFA = 1;
        public const int TeamMaxPlayers_BAL = -1;
        public const int TeamMaxPlayers_V1 = 1;
        public const int TeamMaxPlayers_V2 = 2;
        public const int TeamMaxPlayers_V3 = 3;
        public const int TeamMaxPlayers_V4 = 4;
        public const int TeamMaxPlayers_V22 = 2;

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
        public const int StartElo = 800;
    }
}
