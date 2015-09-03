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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check()) {
                if (newPlayer)
                    mainForm.addPlayer(textBoxName.Text, checkBoxTerran.Checked, checkBoxZerg.Checked, checkBoxProtoss.Checked, checkBoxRandom.Checked);
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
