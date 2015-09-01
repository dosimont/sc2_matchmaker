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
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTerran = new System.Windows.Forms.Label();
            this.labelZerg = new System.Windows.Forms.Label();
            this.labelProtoss = new System.Windows.Forms.Label();
            this.overallContent = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelOverall = new System.Windows.Forms.Label();
            this.nameContent = new System.Windows.Forms.Label();
            this.terranContent = new System.Windows.Forms.Label();
            this.zergContent = new System.Windows.Forms.Label();
            this.protossContent = new System.Windows.Forms.Label();
            this.randomContent = new System.Windows.Forms.Label();
            this.labelRandom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // labelHumanPlayers
            // 
            this.labelHumanPlayers.AutoSize = true;
            this.labelHumanPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumanPlayers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelHumanPlayers.Location = new System.Drawing.Point(9, 36);
            this.labelHumanPlayers.Name = "labelHumanPlayers";
            this.labelHumanPlayers.Size = new System.Drawing.Size(91, 13);
            this.labelHumanPlayers.TabIndex = 1;
            this.labelHumanPlayers.Text = "Human Players";
            this.labelHumanPlayers.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(343, 293);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(262, 293);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(180, 293);
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
            this.checkBoxEnableIA.Location = new System.Drawing.Point(12, 377);
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
            this.checkedListBoxHumanPlayers.Size = new System.Drawing.Size(141, 214);
            this.checkedListBoxHumanPlayers.TabIndex = 5;
            this.checkedListBoxHumanPlayers.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxHumanPlayers_SelectedIndexChanged);
            // 
            // comboBoxMatchType
            // 
            this.comboBoxMatchType.FormattingEnabled = true;
            this.comboBoxMatchType.Location = new System.Drawing.Point(12, 411);
            this.comboBoxMatchType.Name = "comboBoxMatchType";
            this.comboBoxMatchType.Size = new System.Drawing.Size(237, 21);
            this.comboBoxMatchType.TabIndex = 6;
            this.comboBoxMatchType.Text = "Match Type";
            // 
            // buttonCreateTeams
            // 
            this.buttonCreateTeams.Location = new System.Drawing.Point(145, 447);
            this.buttonCreateTeams.Name = "buttonCreateTeams";
            this.buttonCreateTeams.Size = new System.Drawing.Size(104, 23);
            this.buttonCreateTeams.TabIndex = 3;
            this.buttonCreateTeams.Text = "Create Teams";
            this.buttonCreateTeams.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(609, 449);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 3;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(528, 449);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxWinningTeam
            // 
            this.comboBoxWinningTeam.FormattingEnabled = true;
            this.comboBoxWinningTeam.Location = new System.Drawing.Point(447, 411);
            this.comboBoxWinningTeam.Name = "comboBoxWinningTeam";
            this.comboBoxWinningTeam.Size = new System.Drawing.Size(237, 21);
            this.comboBoxWinningTeam.TabIndex = 6;
            this.comboBoxWinningTeam.Text = "Select the Winning Team";
            this.comboBoxWinningTeam.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelMatchmaking
            // 
            this.labelMatchmaking.AutoSize = true;
            this.labelMatchmaking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchmaking.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelMatchmaking.Location = new System.Drawing.Point(444, 36);
            this.labelMatchmaking.Name = "labelMatchmaking";
            this.labelMatchmaking.Size = new System.Drawing.Size(122, 13);
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
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelDetails.Location = new System.Drawing.Point(3, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(46, 13);
            this.labelDetails.TabIndex = 7;
            this.labelDetails.Text = "Details";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelName.Location = new System.Drawing.Point(3, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // labelTerran
            // 
            this.labelTerran.AutoSize = true;
            this.labelTerran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerran.ForeColor = System.Drawing.Color.Blue;
            this.labelTerran.Location = new System.Drawing.Point(3, 60);
            this.labelTerran.Name = "labelTerran";
            this.labelTerran.Size = new System.Drawing.Size(41, 13);
            this.labelTerran.TabIndex = 7;
            this.labelTerran.Text = "Terran:";
            // 
            // labelZerg
            // 
            this.labelZerg.AutoSize = true;
            this.labelZerg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZerg.ForeColor = System.Drawing.Color.Maroon;
            this.labelZerg.Location = new System.Drawing.Point(3, 90);
            this.labelZerg.Name = "labelZerg";
            this.labelZerg.Size = new System.Drawing.Size(32, 13);
            this.labelZerg.TabIndex = 7;
            this.labelZerg.Text = "Zerg:";
            // 
            // labelProtoss
            // 
            this.labelProtoss.AutoSize = true;
            this.labelProtoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProtoss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelProtoss.Location = new System.Drawing.Point(3, 120);
            this.labelProtoss.Name = "labelProtoss";
            this.labelProtoss.Size = new System.Drawing.Size(45, 13);
            this.labelProtoss.TabIndex = 7;
            this.labelProtoss.Text = "Protoss:";
            // 
            // overallContent
            // 
            this.overallContent.AutoSize = true;
            this.overallContent.Location = new System.Drawing.Point(70, 180);
            this.overallContent.Name = "overallContent";
            this.overallContent.Size = new System.Drawing.Size(0, 13);
            this.overallContent.TabIndex = 7;
            this.overallContent.Click += new System.EventHandler(this.labelOverall_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.7533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.2467F));
            this.tableLayoutPanel1.Controls.Add(this.labelOverall, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTerran, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelProtoss, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelZerg, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.terranContent, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.zergContent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.protossContent, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.randomContent, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.overallContent, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelRandom, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(174, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 214);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelOverall
            // 
            this.labelOverall.AutoSize = true;
            this.labelOverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverall.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelOverall.Location = new System.Drawing.Point(3, 180);
            this.labelOverall.Name = "labelOverall";
            this.labelOverall.Size = new System.Drawing.Size(43, 13);
            this.labelOverall.TabIndex = 9;
            this.labelOverall.Text = "Overall:";
            // 
            // nameContent
            // 
            this.nameContent.AutoSize = true;
            this.nameContent.Location = new System.Drawing.Point(70, 30);
            this.nameContent.Name = "nameContent";
            this.nameContent.Size = new System.Drawing.Size(0, 13);
            this.nameContent.TabIndex = 8;
            // 
            // terranContent
            // 
            this.terranContent.AutoSize = true;
            this.terranContent.Location = new System.Drawing.Point(70, 60);
            this.terranContent.Name = "terranContent";
            this.terranContent.Size = new System.Drawing.Size(0, 13);
            this.terranContent.TabIndex = 8;
            // 
            // zergContent
            // 
            this.zergContent.AutoSize = true;
            this.zergContent.Location = new System.Drawing.Point(70, 90);
            this.zergContent.Name = "zergContent";
            this.zergContent.Size = new System.Drawing.Size(0, 13);
            this.zergContent.TabIndex = 8;
            // 
            // protossContent
            // 
            this.protossContent.AutoSize = true;
            this.protossContent.Location = new System.Drawing.Point(70, 120);
            this.protossContent.Name = "protossContent";
            this.protossContent.Size = new System.Drawing.Size(0, 13);
            this.protossContent.TabIndex = 8;
            // 
            // randomContent
            // 
            this.randomContent.AutoSize = true;
            this.randomContent.Location = new System.Drawing.Point(70, 150);
            this.randomContent.Name = "randomContent";
            this.randomContent.Size = new System.Drawing.Size(0, 13);
            this.randomContent.TabIndex = 8;
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandom.ForeColor = System.Drawing.Color.Gray;
            this.labelRandom.Location = new System.Drawing.Point(3, 150);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(50, 13);
            this.labelRandom.TabIndex = 7;
            this.labelRandom.Text = "Random:";
            this.labelRandom.Click += new System.EventHandler(this.labelOverall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Match Parameters";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTerran;
        private System.Windows.Forms.Label labelZerg;
        private System.Windows.Forms.Label labelProtoss;
        private System.Windows.Forms.Label overallContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameContent;
        private System.Windows.Forms.Label terranContent;
        private System.Windows.Forms.Label zergContent;
        private System.Windows.Forms.Label protossContent;
        private System.Windows.Forms.Label randomContent;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Label labelOverall;
        private System.Windows.Forms.Label label1;
    }
}

