using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sc2_matchmaker
{
    class MarkdownExporter
    {
        Core core;
        string file;
        List<List<string>> tabular = new List<List<string>>();
        List<int> maxColumn = new List<int>();

        string HeaderA = "---" + System.Environment.NewLine +
            "layout: sc2" + System.Environment.NewLine;
        string HeaderB = "---" + System.Environment.NewLine;
        //"---" + System.Environment.NewLine + System.Environment.NewLine;


        const string Name = " Name ";
        const string Rank = " Rank ";
        const string Overall = " Overall ";
        const string Terran = " Terran ";
        const string Zerg = " Zerg ";
        const string Protoss = " Protoss ";
        const string Random = " Random ";

        const string Sep = "|";
        const string Li = "-";
        const string Dp = ":";
        const string None = "None";
        const string Sp = " ";

 
        const int RankIndex = 0;
        const int NameIndex = 1;
        const int OverallIndex = 2;
        const int TerranIndex = 3;
        const int ZergIndex = 4;
        const int ProtossIndex = 5;
        const int RandomIndex = 6;
        const int Indices = 7;

        public MarkdownExporter(string file, Core core)
        {
            this.core = core;
            this.file = file;
        }


        public void write()
        {
            //Header
            int i = 0;
            tabular.Add(new List<string>());
            tabular[i].Add(Name);
            tabular[i].Add(Rank);
            tabular[i].Add(Overall);
            tabular[i].Add(Terran);
            tabular[i].Add(Zerg);
            tabular[i].Add(Protoss);
            tabular[i].Add(Random);
            foreach (var player in core.Ranks)
            {
                i++;
                tabular.Add(new List<string>());
                tabular[i].Add(Space(i.ToString()));
                tabular[i].Add(Space(player.Name));
                tabular[i].Add(Space(player.getOverallElo() + " (" + player.getOverallVictory() + "/" + player.getOverallDefeat() + ")"));
                if (player.Races[Constants.Terran])
                    tabular[i].Add(Space(player.Elo[Constants.Terran] + " (" + player.Victory[Constants.Terran] + "/" + player.Defeat[Constants.Terran] + ")"));
                else
                    tabular[i].Add(None);
                if (player.Races[Constants.Zerg])
                    tabular[i].Add(Space(player.Elo[Constants.Zerg] + " (" + player.Victory[Constants.Zerg] + "/" + player.Defeat[Constants.Zerg] + ")"));
                else
                    tabular[i].Add(None);
                if (player.Races[Constants.Protoss])
                    tabular[i].Add(Space(player.Elo[Constants.Protoss] + " (" + player.Victory[Constants.Protoss] + "/" + player.Defeat[Constants.Protoss] + ")"));
                else
                    tabular[i].Add(None);
                if (player.Races[Constants.Random])
                    tabular[i].Add(Space(player.Elo[Constants.Random] + " (" + player.Victory[Constants.Random] + "/" + player.Defeat[Constants.Random] + ")"));
                else
                    tabular[i].Add(None);
            }
            for (int k = 0; k < tabular[0].Count; k++)
            {
                maxColumn.Add(0);
                for (int j = 0; j < tabular.Count; j++)
                {
                    maxColumn[k] = Math.Max(tabular[j][k].Length, maxColumn[k]);
                }
            }
            for (int k = 0; k < tabular[0].Count; k++)
            {
                for (int j = 0; j < tabular.Count; j++)
                {
                    tabular[j][k] += Fill(maxColumn[k] - tabular[j][k].Length);
                }
            }

            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.Write(HeaderA);
                sw.Write("title: "+ Path.GetFileNameWithoutExtension(file) + System.Environment.NewLine);
                sw.Write(HeaderB);
                for (int j = 0; j < tabular.Count; j++)
                {
                    sw.Write(Sep);
                    for (int k = 0; k < tabular[0].Count; k++)
                    {
                        sw.Write(tabular[j][k] + Sep);
                    }
                    sw.Write(System.Environment.NewLine);
                    if (j == 0)
                    {
                        sw.Write(Sep);
                        for (int k = 0; k < tabular[0].Count; k++)
                        {
                            sw.Write(Line(maxColumn[k]) + Sep);
                        }
                        sw.Write(System.Environment.NewLine);
                    }
                }
            }
        }

        public string Space(string str)
        {
            return Sp + str + Sp;
        }

        public string Fill(int diff)
        {
            string fill = "";
            for (int i = 0; i < diff; i++)
                fill += Sp;
            return fill;
        }

        public string Line(int length)
        {
            string line = Dp;
            for (int i = 1; i < length-1; i++)
                line += Li;
            line += Dp;
            return line;
        }
    }
}
