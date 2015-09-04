using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sc2_matchmaker
{
    public partial class TeamForm : Form
    {
        MainForm mainForm;
        List<Team> teams;
        public TeamForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.teams = new List<Team>();
            for (int i=0; i < mainForm.Core.getExpectedTeamNumber(); i++)
            {
                teams.Add(new Team());
            }
            foreach (var item in mainForm.Core.CheckedHumanPlayers.Values)
            {
                listBox1.Items.Add(item);
            }
            radioButtonTerran.Checked = false;
            radioButtonTerran.Enabled = false;
            radioButtonZerg.Checked = false;
            radioButtonZerg.Enabled = false;
            radioButtonProtoss.Checked = false;
            radioButtonProtoss.Enabled = false;
            radioButtonRandom.Checked = false;
            radioButtonRandom.Enabled = false;
            numericUpDownTeam.Minimum = 1;
            numericUpDownTeam.Maximum = mainForm.Core.getExpectedTeamNumber();
            checkTeams();
            checkLists();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Player> selectedHumanPlayers = new List<Player>();
            foreach (var item in listBox1.SelectedItems)
            {
                Player temp = (Player) item;
                selectedHumanPlayers.Add(temp);
            }
            if (selectedHumanPlayers.Count == 1)
            {
                updateInformation(selectedHumanPlayers[0]);
            }
            else
            {
                clearInformation();
            }
        }

        private void clearInformation()
        {
            radioButtonTerran.Enabled = false;
            radioButtonZerg.Enabled = false;
            radioButtonProtoss.Enabled = false;
            radioButtonRandom.Enabled = false;
            radioButtonTerran.Checked = false;
            radioButtonZerg.Checked = false;
            radioButtonProtoss.Checked = false;
            radioButtonRandom.Checked = false;
        }

        private void updateInformation(Player player)
        {
            radioButtonTerran.Enabled = player.Races[Constants.Terran];
            radioButtonZerg.Enabled = player.Races[Constants.Zerg];
            radioButtonProtoss.Enabled = player.Races[Constants.Protoss];
            radioButtonRandom.Enabled = player.Races[Constants.Random];
            radioButtonTerran.Checked = false;
            radioButtonZerg.Checked = false;
            radioButtonProtoss.Checked = false;
            radioButtonRandom.Checked = false;
            if (radioButtonTerran.Enabled)
            {
                radioButtonTerran.Checked = true;
            }
            else if (radioButtonZerg.Enabled)
            {
                radioButtonZerg.Checked = true;
            }
            else if (radioButtonProtoss.Enabled)
            {
                radioButtonProtoss.Checked = true;
            }
            else
            {
                radioButtonRandom.Checked = true;
            }
            numericUpDownTeam.Value = 1;
            if (teams[(int)numericUpDownTeam.Value - 1].Count == mainForm.Core.getExpectedTeamPlayerNumber())
            {
                buttonAdd.Enabled = false;
            }else if (teams[(int)numericUpDownTeam.Value - 1].Count<mainForm.Core.getExpectedTeamPlayerNumber())
            {
                buttonAdd.Enabled = true;
            }

}

        private void radioButtonTerran_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTerran.Checked)
            {
                radioButtonZerg.Checked = false;
                radioButtonProtoss.Checked = false;
                radioButtonRandom.Checked = false;
            }
        }

        private void radioButtonZerg_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonZerg.Checked)
            {
                radioButtonTerran.Checked = false;
                radioButtonProtoss.Checked = false;
                radioButtonRandom.Checked = false;
            }
        }

        private void radioButtonProtoss_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonProtoss.Checked)
            {
                radioButtonZerg.Checked = false;
                radioButtonTerran.Checked = false;
                radioButtonRandom.Checked = false;
            }
        }

        private void radioButtonRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRandom.Checked)
            {
                radioButtonZerg.Checked = false;
                radioButtonProtoss.Checked = false;
                radioButtonTerran.Checked = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int race = 0;
            if (radioButtonTerran.Checked)
            {
                race = Constants.Terran;
            }
            else if (radioButtonZerg.Checked)
            {
                race = Constants.Zerg;
            }
            else if (radioButtonProtoss.Checked)
            {
                race = Constants.Protoss;
            }
            else if (radioButtonRandom.Checked)
            {
                race = Constants.Random;
            }
            List<Player> selectedHumanPlayers = new List<Player>();
            foreach (var item in listBox1.SelectedItems)
            {
                Player temp = (Player) item;
                selectedHumanPlayers.Add(temp);
            }
            if (selectedHumanPlayers.Count == 1)
            {
                teams[(int)numericUpDownTeam.Value - 1].addMember(selectedHumanPlayers[0], race);
                PlayerWrapper playerWrapper = new PlayerWrapper(selectedHumanPlayers[0], race, (int)numericUpDownTeam.Value);
                listBox1.Items.Remove(selectedHumanPlayers[0]);
                listBox2.Items.Add(playerWrapper);
                checkTeams();
            }
            checkLists();

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            List<PlayerWrapper> selectedWrappers = new List<PlayerWrapper>();
            foreach (var item in listBox2.SelectedItems)
            {
                PlayerWrapper temp = (PlayerWrapper)item;
                selectedWrappers.Add(temp);
            }
            if (selectedWrappers.Count == 1)
            {
                teams[selectedWrappers[0].TeamNumber - 1].RemoveMember(selectedWrappers[0].Player);
                listBox2.Items.Remove(selectedWrappers[0]);
                listBox1.Items.Add(selectedWrappers[0].Player);
                checkTeams();
            }
            checkLists();
        }

        private void checkTeams()
        {
            buttonOK.Enabled = false;
            if (teams.Count == mainForm.Core.getExpectedTeamNumber())
            {
                buttonOK.Enabled = true;
                foreach (var item in teams)
                {
                    if (item.Count != mainForm.Core.getExpectedTeamPlayerNumber())
                    {
                        buttonOK.Enabled = false;
                    }
                }
            }
        }

        private void checkLists()
        {
            if (listBox1.Items.Count == 0)
            {
                buttonAdd.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
            }
            if (listBox2.Items.Count == 0)
            {
                buttonRemove.Enabled = false;
            }
            else
            {
                buttonRemove.Enabled = true;
            }
        }

        private void numericUpDownTeam_ValueChanged(object sender, EventArgs e)
        {
            if (teams[(int)numericUpDownTeam.Value - 1].Count == mainForm.Core.getExpectedTeamPlayerNumber())
            {
                buttonAdd.Enabled = false;
            }else if (teams[(int)numericUpDownTeam.Value - 1].Count < mainForm.Core.getExpectedTeamPlayerNumber())
            {
                buttonAdd.Enabled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            teams.Clear();
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            mainForm.manualMatch(teams);
            Close();
        }
    }
}
