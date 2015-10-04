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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sc2_matchmaker
{
    public partial class MainForm : Form
    {
        private string currentFile = null;
        private Core core = new Core();
        const string title = "SC2 Matchmaker";
        const string ast = " *";
        bool modif = false;

        internal Core Core
        {
            get
            {
                return core;
            }

            set
            {
                core = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            comboBoxMatchType.Items.Add(Constants.FFA);
            //comboBoxMatchType.Items.Add(Constants.BAL);
            comboBoxMatchType.Items.Add(Constants.V1);
            comboBoxMatchType.Items.Add(Constants.V2);
            comboBoxMatchType.Items.Add(Constants.V22);
            comboBoxMatchType.Items.Add(Constants.V222);
            comboBoxMatchType.Items.Add(Constants.V3);
            comboBoxMatchType.Items.Add(Constants.V33);
            comboBoxMatchType.Items.Add(Constants.V4);
            comboBoxMatchType.SelectedIndex = 0;
            checkedListBoxHumanPlayers.Sorted = true;
            comboBoxWinningTeam.Enabled = false;
            buttonValidate.Enabled = false;
            buttonCreateTeamsAuto.Enabled = true;
            unsaved();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonValidate.Enabled = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core = new Core();
            currentFile = null;
            checkedListBoxHumanPlayers.Items.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "All files (*.*)|*.*|SC2 Matchmaker profile (*.sc2mp)|*.sc2mp";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((currentFile = openFileDialog1.FileName) != null)
                    {
                        Core = new Core(currentFile);
                        core.openPlayers();
                        actualizeCheckedListPlayer();
                        core.computeRanks();
                        saved();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PlayerForm addPlayerForm = new PlayerForm(this);
            addPlayerForm.Show();
        }

        public void addPlayer(string name, bool terran, bool zerg, bool protoss, bool random)
        {
            core.addPlayer(name, terran, zerg, protoss, random);
            checkedListBoxHumanPlayers.Items.Add(core.HumanPlayers[name], false);
            updateDetailsDisplay();
        }

        public void modifyPlayer(Player player, string newname, bool terran, bool zerg, bool protoss, bool random)
        {
            bool checkedItem = checkedListBoxHumanPlayers.GetItemChecked(checkedListBoxHumanPlayers.Items.IndexOf(player));
            checkedListBoxHumanPlayers.Items.Remove(player);
            core.modifyPlayer(player, newname, terran, zerg, protoss, random);
            checkedListBoxHumanPlayers.Items.Add(core.HumanPlayers[newname], checkedItem);
            checkedListBoxHumanPlayers.SelectedItem=core.HumanPlayers[newname];
            updateDetailsDisplay();
        }

        internal void addPlayer(string name, bool terran, bool zerg, bool protoss, bool random, string terranLvl, string zergLvl, string protossLvl, string randomLvl)
        {
            core.addPlayer(name, terran, zerg, protoss, random, terranLvl, zergLvl, protossLvl, randomLvl);
            checkedListBoxHumanPlayers.Items.Add(core.HumanPlayers[name], false);
            updateDetailsDisplay();
            
        }

        public void actualizeCheckedListPlayer()
        {
            checkedListBoxHumanPlayers.Items.Clear();
            foreach (var item in core.HumanPlayers)
            {
                checkedListBoxHumanPlayers.Items.Add(core.HumanPlayers[item.Key], false);
            }   
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            List<Player> selectedHumanPlayers = new List<Player>();
            foreach (var item in checkedListBoxHumanPlayers.SelectedItems)
            {
                Player temp = (Player)item;
                selectedHumanPlayers.Add(temp);
            }
            if (selectedHumanPlayers.Count == 1)
            {
                PlayerForm addPlayerForm = new PlayerForm(this, selectedHumanPlayers[0]);
                addPlayerForm.Show();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            List<Player> selectedHumanPlayers=new List<Player>();
            foreach (var item in checkedListBoxHumanPlayers.SelectedItems)
            {
                Player temp = (Player) item;
                selectedHumanPlayers.Add(temp);
            }
            foreach (var item in selectedHumanPlayers)
            {
                checkedListBoxHumanPlayers.Items.Remove(item);
                core.removePlayer(item.Name);
            }
            updateDetailsDisplay();
            unsaved();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFile == null)
            {
                saveAs();
            }
            else
            {
                core.CurrentFile = currentFile;
                core.savePlayers();
            }
            saved();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveAs()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "All files (*.*)|*.*|SC2 Matchmaker profile (*.sc2mp)|*.sc2mp";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((currentFile = saveFileDialog1.FileName) != null)
                    {
                        core.CurrentFile = currentFile;
                        core.savePlayers();
                        saved();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file. Original error: " + ex.Message);
                }
            } 
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBoxHumanPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDetailsDisplay();
        }

        private void updateDetailsDisplay()
        {
            List<Player> selectedHumanPlayers = new List<Player>();
            foreach (var item in checkedListBoxHumanPlayers.SelectedItems)
            {
                Player temp = (Player)item;
                selectedHumanPlayers.Add(temp);
            }
            if (selectedHumanPlayers.Count == 1)
            {
                updateInformation(selectedHumanPlayers[0]);
            }
        }

        private void updateCheckedHumanPlayers()
        {
            Dictionary<string, Player> checkedHumanPlayers= new Dictionary<string, Player>() ;
            foreach (var item in checkedListBoxHumanPlayers.CheckedItems)
            {
                Player temp = (Player)item;
                checkedHumanPlayers.Add(temp.Name,temp);
            }
            core.CheckedHumanPlayers = checkedHumanPlayers;
        }

        private void updateInformation(Player player)
        {
            core.computeRanks();
            nameContent.Text = player.Name;
            rankedContent.Text = core.getRank(player).ToString();
            if (player.hasBeenPlayed(Constants.Terran))
            {
                terranContent.Text = "Win: " + player.Victory[Constants.Terran] + ", Loss: " + player.Defeat[Constants.Terran] + ", Elo: " + player.Elo[Constants.Terran];
            }
            else
            {
                terranContent.Text = "Estimated Elo: " + player.Elo[Constants.Terran];
            }
            if (player.hasBeenPlayed(Constants.Zerg))
            {
                zergContent.Text = "Win: " + player.Victory[Constants.Zerg] + ", Loss: " + player.Defeat[Constants.Zerg] + ", Elo: " + player.Elo[Constants.Zerg];
            }
            else
            {
                zergContent.Text = "Estimated Elo: " + player.Elo[Constants.Zerg];
            }
            if (player.hasBeenPlayed(Constants.Protoss))
            {
                protossContent.Text = "Win: " + player.Victory[Constants.Protoss] + ", Loss: " + player.Defeat[Constants.Protoss] + ", Elo: " + player.Elo[Constants.Protoss];
            }
            else
            {
                protossContent.Text = "Estimated Elo: " + player.Elo[Constants.Protoss];
            }
            if (player.hasBeenPlayed(Constants.Random))
            {
                randomContent.Text = "Win: " + player.Victory[Constants.Random] + ", Loss: " + player.Defeat[Constants.Random] + ", Elo: " + player.Elo[Constants.Random];
            }
            else
            {
                randomContent.Text = "Estimated Elo: " + player.Elo[Constants.Random];
            }
            overallContent.Text = "Win: " + player.getOverallVictory() + ", Loss: " + player.getOverallDefeat() + ", Elo: " + player.getOverallElo();
            terranContent.Enabled = player.Races[Constants.Terran];
            labelTerran.Enabled = player.Races[Constants.Terran];
            zergContent.Enabled = player.Races[Constants.Zerg];
            labelZerg.Enabled = player.Races[Constants.Zerg];
            protossContent.Enabled = player.Races[Constants.Protoss];
            labelProtoss.Enabled = player.Races[Constants.Protoss];
            randomContent.Enabled = player.Races[Constants.Random];
            labelRandom.Enabled = player.Races[Constants.Random];
            terranContent.ForeColor = labelTerran.ForeColor;
            zergContent.ForeColor = labelZerg.ForeColor;
            protossContent.ForeColor = labelProtoss.ForeColor;
            randomContent.ForeColor = labelRandom.ForeColor;

        }

        private void labelOverall_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            updateCheckedHumanPlayers();

            core.MatchType = comboBoxMatchType.Text;
            try
            {
                core.computeMatchmaking();
                printTeams();
                selectTeams();
                comboBoxWinningTeam.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            updateCheckedHumanPlayers();

            core.MatchType = comboBoxMatchType.Text;
            try {
                core.computeMatchmaking();
                printTeams();
                selectTeams();
                comboBoxWinningTeam.Enabled = true;
            }catch(Exception ex)
            {
            MessageBox.Show("Error: "+ex.Message);
            return;
            }
        }

        private void printTeams()
        {
            int i = 0;
            string str="Matchmaking score (lower is better): "+(int)core.CurrentScore+ Environment.NewLine+Environment.NewLine;
            foreach(var team in core.CurrentTeams)
            {
                i++;
                str += "Team " + i + ":" + Environment.NewLine;
                str += team + Environment.NewLine+Environment.NewLine;
            }
            richTextBoxTeams.Text = str;
        }

        private void clearTeams()
        {
            richTextBoxTeams.Text = "";
        }

        private void selectTeams()
        {
            comboBoxWinningTeam.Items.Clear();
            comboBoxWinningTeam.Enabled = true;
            for (int i = 1; i <= core.CurrentTeams.Count;i++)
            {
                string str = "Team " + i;
                comboBoxWinningTeam.Items.Add(str);
            }
        }

        private void validateTeam()
        {
            core.winningTeam(comboBoxWinningTeam.SelectedIndex);
            unsaved();
        }

        public void unsaved()
        {
            modif = true;
            if (currentFile != null)
                Text = title + " - " + Path.GetFileName(currentFile) + ast;
            else
                Text = title + " - New File" + ast;
        }

        public void saved()
        {
            modif = false;
            if (currentFile != null)
                Text = title + " - " + Path.GetFileName(currentFile);
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            validateTeam();
            comboBoxWinningTeam.Enabled = false;
            comboBoxWinningTeam.Items.Clear();
            comboBoxWinningTeam.Text = "Select the Winning Team";
            buttonValidate.Enabled = false;
            buttonCreateTeamsAuto.Enabled = true;
            clearTeams();
            updateDetailsDisplay();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            comboBoxWinningTeam.Enabled = false;
            comboBoxWinningTeam.Items.Clear();
            comboBoxWinningTeam.Text = "Select the Winning Team";
            buttonValidate.Enabled = false;
            buttonCreateTeamsAuto.Enabled = true;
            clearTeams();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            List<Player> selectedHumanPlayers = new List<Player>();
            foreach (var item in checkedListBoxHumanPlayers.SelectedItems)
            {
                Player temp = (Player)item;
                selectedHumanPlayers.Add(temp);
            }
            if (selectedHumanPlayers.Count == 1)
            {
                selectedHumanPlayers[0].reset();
            }
            updateDetailsDisplay();
        }

        private void buttonUncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxHumanPlayers.Items.Count; i++)
            {
                checkedListBoxHumanPlayers.SetItemChecked(i, false);
            }
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxHumanPlayers.Items.Count; i++)
            {
                checkedListBoxHumanPlayers.SetItemChecked(i, true);
            }  
        }

        private void buttonCreateTeamsManual_Click(object sender, EventArgs e)
        {
            updateCheckedHumanPlayers();
            core.MatchType = comboBoxMatchType.Text;
            try
            {
                core.checkMatch();
                TeamForm teamForm = new TeamForm(this);
                teamForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
           }
        }

        public void manualMatch(List<Team> teams)
        {
            core.computeMatchmaking(teams);
            printTeams();
            selectTeams();
            comboBoxWinningTeam.Enabled = true;
        }

        private void markdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "All files (*.*)|*.*|Markdown file (*.md)|*.md";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string exportFile = null;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((exportFile = saveFileDialog1.FileName) != null)
                    {
                        core.Export(exportFile);
                    }
               }
                catch (Exception ex)
               {
                    MessageBox.Show("Error: Could not export file. Original error: " + ex.Message);
               }
            }
        }
    }
}
