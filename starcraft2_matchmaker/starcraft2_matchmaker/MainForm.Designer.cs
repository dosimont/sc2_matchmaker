using System;

namespace starcraft2_matchmaker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHumanPlayers = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.checkBoxEnableIA = new System.Windows.Forms.CheckBox();
            this.checkedListBoxHumanPlayers = new System.Windows.Forms.CheckedListBox();
            this.comboBoxMatchType = new System.Windows.Forms.ComboBox();
            this.buttonCreateTeams = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxWinningTeam = new System.Windows.Forms.ComboBox();
            this.labelMatchmaking = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // labelHumanPlayers
            // 
            this.labelHumanPlayers.AutoSize = true;
            this.labelHumanPlayers.Location = new System.Drawing.Point(9, 36);
            this.labelHumanPlayers.Name = "labelHumanPlayers";
            this.labelHumanPlayers.Size = new System.Drawing.Size(78, 13);
            this.labelHumanPlayers.TabIndex = 1;
            this.labelHumanPlayers.Text = "Human Players";
            this.labelHumanPlayers.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(311, 293);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(230, 293);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(149, 293);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // checkBoxEnableIA
            // 
            this.checkBoxEnableIA.AutoSize = true;
            this.checkBoxEnableIA.Enabled = false;
            this.checkBoxEnableIA.Location = new System.Drawing.Point(12, 332);
            this.checkBoxEnableIA.Name = "checkBoxEnableIA";
            this.checkBoxEnableIA.Size = new System.Drawing.Size(72, 17);
            this.checkBoxEnableIA.TabIndex = 4;
            this.checkBoxEnableIA.Text = "Enable IA";
            this.checkBoxEnableIA.UseVisualStyleBackColor = true;
            this.checkBoxEnableIA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkedListBoxHumanPlayers
            // 
            this.checkedListBoxHumanPlayers.FormattingEnabled = true;
            this.checkedListBoxHumanPlayers.Location = new System.Drawing.Point(12, 64);
            this.checkedListBoxHumanPlayers.Name = "checkedListBoxHumanPlayers";
            this.checkedListBoxHumanPlayers.Size = new System.Drawing.Size(374, 214);
            this.checkedListBoxHumanPlayers.TabIndex = 5;
            // 
            // comboBoxMatchType
            // 
            this.comboBoxMatchType.FormattingEnabled = true;
            this.comboBoxMatchType.Location = new System.Drawing.Point(12, 366);
            this.comboBoxMatchType.Name = "comboBoxMatchType";
            this.comboBoxMatchType.Size = new System.Drawing.Size(374, 21);
            this.comboBoxMatchType.TabIndex = 6;
            this.comboBoxMatchType.Text = "Match Type";
            // 
            // buttonCreateTeams
            // 
            this.buttonCreateTeams.Location = new System.Drawing.Point(282, 402);
            this.buttonCreateTeams.Name = "buttonCreateTeams";
            this.buttonCreateTeams.Size = new System.Drawing.Size(104, 23);
            this.buttonCreateTeams.TabIndex = 3;
            this.buttonCreateTeams.Text = "Create Teams";
            this.buttonCreateTeams.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(717, 402);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 3;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(636, 402);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxWinningTeam
            // 
            this.comboBoxWinningTeam.FormattingEnabled = true;
            this.comboBoxWinningTeam.Location = new System.Drawing.Point(418, 366);
            this.comboBoxWinningTeam.Name = "comboBoxWinningTeam";
            this.comboBoxWinningTeam.Size = new System.Drawing.Size(374, 21);
            this.comboBoxWinningTeam.TabIndex = 6;
            this.comboBoxWinningTeam.Text = "Select the Winning Team";
            this.comboBoxWinningTeam.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelMatchmaking
            // 
            this.labelMatchmaking.AutoSize = true;
            this.labelMatchmaking.Location = new System.Drawing.Point(415, 36);
            this.labelMatchmaking.Name = "labelMatchmaking";
            this.labelMatchmaking.Size = new System.Drawing.Size(104, 13);
            this.labelMatchmaking.TabIndex = 7;
            this.labelMatchmaking.Text = "Matchmaking Result";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(296, 64);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 437);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelMatchmaking);
            this.Controls.Add(this.comboBoxWinningTeam);
            this.Controls.Add(this.comboBoxMatchType);
            this.Controls.Add(this.checkedListBoxHumanPlayers);
            this.Controls.Add(this.checkBoxEnableIA);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonCreateTeams);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelHumanPlayers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Starcraft 2 Matchmaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Label labelHumanPlayers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.CheckBox checkBoxEnableIA;
        private System.Windows.Forms.CheckedListBox checkedListBoxHumanPlayers;
        private System.Windows.Forms.ComboBox comboBoxMatchType;
        private System.Windows.Forms.Button buttonCreateTeams;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxWinningTeam;
        private System.Windows.Forms.Label labelMatchmaking;
        private System.Windows.Forms.Label labelResult;
    }
}

