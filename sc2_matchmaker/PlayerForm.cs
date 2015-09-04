/*This file is part of SC 2 Matchmaker.

SC 2 Matchmaker is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 3 of the License.

SC 2 Matchmaker is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Foobar.  If not, see<http://www.gnu.org/licenses/>.

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

namespace sc2_matchmaker
{
    public partial class PlayerForm : Form
    {

        MainForm mainForm;
        Player player;
        bool newPlayer = true;
        public PlayerForm(MainForm mainForm)
        {
            this.mainForm=mainForm;
            InitializeComponent();
            Text = "Add Player";
            comboBoxTerran.Items.Add(Constants.Unranked);
            comboBoxTerran.Items.Add(Constants.Bronze);
            comboBoxTerran.Items.Add(Constants.Silver);
            comboBoxTerran.Items.Add(Constants.Gold);
            comboBoxTerran.Items.Add(Constants.Platine);
            comboBoxTerran.Items.Add(Constants.Diamond);
            comboBoxTerran.Items.Add(Constants.Master);
            comboBoxTerran.Items.Add(Constants.GrandMaster);
            comboBoxTerran.SelectedIndex = 0;
            comboBoxZerg.Items.Add(Constants.Unranked);
            comboBoxZerg.Items.Add(Constants.Bronze);
            comboBoxZerg.Items.Add(Constants.Silver);
            comboBoxZerg.Items.Add(Constants.Gold);
            comboBoxZerg.Items.Add(Constants.Platine);
            comboBoxZerg.Items.Add(Constants.Diamond);
            comboBoxZerg.Items.Add(Constants.Master);
            comboBoxZerg.Items.Add(Constants.GrandMaster);
            comboBoxZerg.SelectedIndex = 0;
            comboBoxProtoss.Items.Add(Constants.Unranked);
            comboBoxProtoss.Items.Add(Constants.Bronze);
            comboBoxProtoss.Items.Add(Constants.Silver);
            comboBoxProtoss.Items.Add(Constants.Gold);
            comboBoxProtoss.Items.Add(Constants.Platine);
            comboBoxProtoss.Items.Add(Constants.Diamond);
            comboBoxProtoss.Items.Add(Constants.Master);
            comboBoxProtoss.Items.Add(Constants.GrandMaster);
            comboBoxProtoss.SelectedIndex = 0;
            comboBoxRandom.Items.Add(Constants.Unranked);
            comboBoxRandom.Items.Add(Constants.Bronze);
            comboBoxRandom.Items.Add(Constants.Silver);
            comboBoxRandom.Items.Add(Constants.Gold);
            comboBoxRandom.Items.Add(Constants.Platine);
            comboBoxRandom.Items.Add(Constants.Diamond);
            comboBoxRandom.Items.Add(Constants.Master);
            comboBoxRandom.Items.Add(Constants.GrandMaster);
            comboBoxRandom.SelectedIndex = 0;
        }

        public PlayerForm(MainForm mainForm, Player player)
        {
            this.mainForm = mainForm;
            this.player = player;
            this.newPlayer = false;
            InitializeComponent();
            textBoxName.Text = player.Name;
            checkBoxTerran.Checked = player.Races[Constants.Terran];
            checkBoxZerg.Checked = player.Races[Constants.Zerg];
            checkBoxProtoss.Checked = player.Races[Constants.Protoss];
            checkBoxRandom.Checked = player.Races[Constants.Random];
            comboBoxTerran.Enabled = false;
            comboBoxZerg.Enabled = false;
            comboBoxProtoss.Enabled = false;
            comboBoxRandom.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (check()) {
                if (newPlayer)
                    mainForm.addPlayer(textBoxName.Text, checkBoxTerran.Checked, checkBoxZerg.Checked, checkBoxProtoss.Checked, checkBoxRandom.Checked, (string) comboBoxTerran.SelectedItem, (string) comboBoxZerg.SelectedItem, (string) comboBoxProtoss.SelectedItem, (string) comboBoxRandom.SelectedItem);
                else
                    mainForm.modifyPlayer(player, textBoxName.Text, checkBoxTerran.Checked, checkBoxZerg.Checked, checkBoxProtoss.Checked, checkBoxRandom.Checked);
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool check(){
            if (textBoxName.Text.Equals(""))
            {
                MessageBox.Show("Error: you must define a name");
                return false;
            }
            if (mainForm.Core.HumanPlayers.ContainsKey(textBoxName.Text))
            {
                if (!newPlayer && !textBoxName.Text.Equals(player.Name) || newPlayer)
                {
                    MessageBox.Show("Error: this name is already taken by an other player");
                    return false;
                }
            }
            if (!checkBoxTerran.Checked && !checkBoxZerg.Checked && !checkBoxProtoss.Checked && !checkBoxRandom.Checked)
            {
                MessageBox.Show("Error: at least one race must be selected");
                return false;
            }
            return true;
        }
    }
}
