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

namespace starcraft2_matchmaker
{
    public partial class MainForm : Form
    {
        private string currentFile = null;
        private Core core = new Core();

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
            comboBoxMatchType.Items.Add(Constants.BAL);
            comboBoxMatchType.Items.Add(Constants.V1);
            comboBoxMatchType.Items.Add(Constants.V2);
            comboBoxMatchType.Items.Add(Constants.V22);
            comboBoxMatchType.Items.Add(Constants.V3);
            comboBoxMatchType.Items.Add(Constants.V4);
            comboBoxMatchType.SelectedIndex = 0;
            
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
        }

        public void modifyPlayer(Player player, string newname, bool terran, bool zerg, bool protoss, bool random)
        {
            bool checkedItem = checkedListBoxHumanPlayers.GetItemChecked(checkedListBoxHumanPlayers.Items.IndexOf(player));
            checkedListBoxHumanPlayers.Items.Remove(player);
            core.modifyPlayer(player, newname, terran, zerg, protoss, random);
            checkedListBoxHumanPlayers.Items.Add(core.HumanPlayers[newname], checkedItem);
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

        private void updateInformation(Player player)
        {
            nameContent.Text = player.Name;
            terranContent.Text = "Win: " + player.Victory[Constants.Terran] + ", Loss: " + player.Defeat[Constants.Terran] + ", Ratio: " + player.Score[Constants.Terran].ToString("0.00");
            zergContent.Text = "Win: " + player.Victory[Constants.Zerg] + ", Loss: " + player.Defeat[Constants.Zerg] + ", Ratio: " + player.Score[Constants.Zerg].ToString("0.00");
            protossContent.Text = "Win: " + player.Victory[Constants.Protoss] + ", Loss: " + player.Defeat[Constants.Protoss] + ", Ratio: " + player.Score[Constants.Protoss].ToString("0.00");
            randomContent.Text = "Win: " + player.Victory[Constants.Random] + ", Loss: " + player.Defeat[Constants.Random] + ", Ratio: " + player.Score[Constants.Random].ToString("0.00");
            int overallVictory = player.Victory[Constants.Terran] + player.Victory[Constants.Zerg] + player.Victory[Constants.Protoss] + player.Victory[Constants.Random];
            int overallDefeat = player.Defeat[Constants.Terran] + player.Defeat[Constants.Zerg] + player.Defeat[Constants.Protoss] + player.Defeat[Constants.Random];
            double overallRatio = 0;
            if (overallVictory!=0)
                overallRatio= (double)(overallVictory) / (double)(overallVictory + overallDefeat);
            overallContent.Text = "Win: " + overallVictory + ", Loss: " + overallDefeat + ", Ratio: " + overallRatio.ToString("0.00");
        }

        private void labelOverall_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
