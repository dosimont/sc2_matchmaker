using System;

namespace sc2_matchmaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxMatchType = new System.Windows.Forms.ComboBox();
            this.buttonCreateTeamsAuto = new System.Windows.Forms.Button();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.comboBoxWinningTeam = new System.Windows.Forms.ComboBox();
            this.labelMatchmaking = new System.Windows.Forms.Label();
            this.labelParameters = new System.Windows.Forms.Label();
            this.labelMarchResult = new System.Windows.Forms.Label();
            this.richTextBoxTeams = new System.Windows.Forms.RichTextBox();
            this.buttonCreateTeamsManual = new System.Windows.Forms.Button();
            this.labelCreateTeams = new System.Windows.Forms.Label();
            this.rankedContent = new System.Windows.Forms.Label();
            this.terranContent = new System.Windows.Forms.Label();
            this.zergContent = new System.Windows.Forms.Label();
            this.protossContent = new System.Windows.Forms.Label();
            this.randomContent = new System.Windows.Forms.Label();
            this.labelRanked = new System.Windows.Forms.Label();
            this.labelTerran = new System.Windows.Forms.Label();
            this.labelZerg = new System.Windows.Forms.Label();
            this.labelProtoss = new System.Windows.Forms.Label();
            this.labelRandom = new System.Windows.Forms.Label();
            this.nameContent = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelOverall = new System.Windows.Forms.Label();
            this.overallContent = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelHumanPlayers = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.checkedListBoxHumanPlayers = new System.Windows.Forms.CheckedListBox();
            this.buttonCheckAll = new System.Windows.Forms.Button();
            this.buttonUncheckAll = new System.Windows.Forms.Button();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.connectedModeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markdownToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // markdownToolStripMenuItem
            // 
            this.markdownToolStripMenuItem.Name = "markdownToolStripMenuItem";
            this.markdownToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.markdownToolStripMenuItem.Text = "Markdown";
            this.markdownToolStripMenuItem.Click += new System.EventHandler(this.markdownToolStripMenuItem_Click);
            // 
            // connectedModeToolStripMenuItem
            // 
            this.connectedModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem});
            this.connectedModeToolStripMenuItem.Name = "connectedModeToolStripMenuItem";
            this.connectedModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectedModeToolStripMenuItem.Text = "Connect";
            this.connectedModeToolStripMenuItem.Click += new System.EventHandler(this.connectedModeToolStripMenuItem_Click);
            // 
            // comboBoxMatchType
            // 
            this.comboBoxMatchType.FormattingEnabled = true;
            this.comboBoxMatchType.Location = new System.Drawing.Point(12, 434);
            this.comboBoxMatchType.Name = "comboBoxMatchType";
            this.comboBoxMatchType.Size = new System.Drawing.Size(412, 21);
            this.comboBoxMatchType.TabIndex = 6;
            this.comboBoxMatchType.Text = "Match Type";
            // 
            // buttonCreateTeamsAuto
            // 
            this.buttonCreateTeamsAuto.Location = new System.Drawing.Point(300, 510);
            this.buttonCreateTeamsAuto.Name = "buttonCreateTeamsAuto";
            this.buttonCreateTeamsAuto.Size = new System.Drawing.Size(59, 23);
            this.buttonCreateTeamsAuto.TabIndex = 3;
            this.buttonCreateTeamsAuto.Text = "Auto";
            this.buttonCreateTeamsAuto.UseVisualStyleBackColor = true;
            this.buttonCreateTeamsAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(365, 844);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(59, 23);
            this.buttonValidate.TabIndex = 3;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // comboBoxWinningTeam
            // 
            this.comboBoxWinningTeam.FormattingEnabled = true;
            this.comboBoxWinningTeam.Location = new System.Drawing.Point(12, 817);
            this.comboBoxWinningTeam.Name = "comboBoxWinningTeam";
            this.comboBoxWinningTeam.Size = new System.Drawing.Size(412, 21);
            this.comboBoxWinningTeam.TabIndex = 6;
            this.comboBoxWinningTeam.Text = "Select the Winning Team";
            this.comboBoxWinningTeam.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelMatchmaking
            // 
            this.labelMatchmaking.AutoSize = true;
            this.labelMatchmaking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchmaking.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelMatchmaking.Location = new System.Drawing.Point(9, 548);
            this.labelMatchmaking.Name = "labelMatchmaking";
            this.labelMatchmaking.Size = new System.Drawing.Size(44, 13);
            this.labelMatchmaking.TabIndex = 7;
            this.labelMatchmaking.Text = "Teams";
            // 
            // labelParameters
            // 
            this.labelParameters.AutoSize = true;
            this.labelParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParameters.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelParameters.Location = new System.Drawing.Point(9, 407);
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(109, 13);
            this.labelParameters.TabIndex = 9;
            this.labelParameters.Text = "Match Parameters";
            this.labelParameters.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelMarchResult
            // 
            this.labelMarchResult.AutoSize = true;
            this.labelMarchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarchResult.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelMarchResult.Location = new System.Drawing.Point(9, 789);
            this.labelMarchResult.Name = "labelMarchResult";
            this.labelMarchResult.Size = new System.Drawing.Size(82, 13);
            this.labelMarchResult.TabIndex = 10;
            this.labelMarchResult.Text = "Match Result";
            // 
            // richTextBoxTeams
            // 
            this.richTextBoxTeams.Location = new System.Drawing.Point(15, 574);
            this.richTextBoxTeams.Name = "richTextBoxTeams";
            this.richTextBoxTeams.Size = new System.Drawing.Size(407, 201);
            this.richTextBoxTeams.TabIndex = 11;
            this.richTextBoxTeams.Text = "";
            // 
            // buttonCreateTeamsManual
            // 
            this.buttonCreateTeamsManual.Location = new System.Drawing.Point(365, 510);
            this.buttonCreateTeamsManual.Name = "buttonCreateTeamsManual";
            this.buttonCreateTeamsManual.Size = new System.Drawing.Size(59, 23);
            this.buttonCreateTeamsManual.TabIndex = 13;
            this.buttonCreateTeamsManual.Text = "Manual";
            this.buttonCreateTeamsManual.UseVisualStyleBackColor = true;
            this.buttonCreateTeamsManual.Click += new System.EventHandler(this.buttonCreateTeamsManual_Click);
            // 
            // labelCreateTeams
            // 
            this.labelCreateTeams.AutoSize = true;
            this.labelCreateTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateTeams.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelCreateTeams.Location = new System.Drawing.Point(9, 479);
            this.labelCreateTeams.Name = "labelCreateTeams";
            this.labelCreateTeams.Size = new System.Drawing.Size(85, 13);
            this.labelCreateTeams.TabIndex = 9;
            this.labelCreateTeams.Text = "Create Teams";
            this.labelCreateTeams.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rankedContent
            // 
            this.rankedContent.AutoSize = true;
            this.rankedContent.Location = new System.Drawing.Point(63, 54);
            this.rankedContent.Name = "rankedContent";
            this.rankedContent.Size = new System.Drawing.Size(0, 13);
            this.rankedContent.TabIndex = 17;
            // 
            // terranContent
            // 
            this.terranContent.AutoSize = true;
            this.terranContent.Location = new System.Drawing.Point(63, 81);
            this.terranContent.Name = "terranContent";
            this.terranContent.Size = new System.Drawing.Size(0, 13);
            this.terranContent.TabIndex = 8;
            // 
            // zergContent
            // 
            this.zergContent.AutoSize = true;
            this.zergContent.Location = new System.Drawing.Point(63, 108);
            this.zergContent.Name = "zergContent";
            this.zergContent.Size = new System.Drawing.Size(0, 13);
            this.zergContent.TabIndex = 8;
            // 
            // protossContent
            // 
            this.protossContent.AutoSize = true;
            this.protossContent.Location = new System.Drawing.Point(63, 135);
            this.protossContent.Name = "protossContent";
            this.protossContent.Size = new System.Drawing.Size(0, 13);
            this.protossContent.TabIndex = 8;
            // 
            // randomContent
            // 
            this.randomContent.AutoSize = true;
            this.randomContent.Location = new System.Drawing.Point(63, 162);
            this.randomContent.Name = "randomContent";
            this.randomContent.Size = new System.Drawing.Size(0, 13);
            this.randomContent.TabIndex = 8;
            // 
            // labelRanked
            // 
            this.labelRanked.AutoSize = true;
            this.labelRanked.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRanked.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRanked.Location = new System.Drawing.Point(3, 54);
            this.labelRanked.Name = "labelRanked";
            this.labelRanked.Size = new System.Drawing.Size(36, 13);
            this.labelRanked.TabIndex = 9;
            this.labelRanked.Text = "Rank:";
            // 
            // labelTerran
            // 
            this.labelTerran.AutoSize = true;
            this.labelTerran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerran.ForeColor = System.Drawing.Color.Blue;
            this.labelTerran.Location = new System.Drawing.Point(3, 81);
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
            this.labelZerg.Location = new System.Drawing.Point(3, 108);
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
            this.labelProtoss.Location = new System.Drawing.Point(3, 135);
            this.labelProtoss.Name = "labelProtoss";
            this.labelProtoss.Size = new System.Drawing.Size(45, 13);
            this.labelProtoss.TabIndex = 7;
            this.labelProtoss.Text = "Protoss:";
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelRandom.Location = new System.Drawing.Point(3, 162);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(50, 13);
            this.labelRandom.TabIndex = 7;
            this.labelRandom.Text = "Random:";
            this.labelRandom.Click += new System.EventHandler(this.labelOverall_Click);
            // 
            // nameContent
            // 
            this.nameContent.AutoSize = true;
            this.nameContent.Location = new System.Drawing.Point(63, 27);
            this.nameContent.Name = "nameContent";
            this.nameContent.Size = new System.Drawing.Size(0, 13);
            this.nameContent.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelName.Location = new System.Drawing.Point(3, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
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
            // labelOverall
            // 
            this.labelOverall.AutoSize = true;
            this.labelOverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverall.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelOverall.Location = new System.Drawing.Point(3, 189);
            this.labelOverall.Name = "labelOverall";
            this.labelOverall.Size = new System.Drawing.Size(43, 13);
            this.labelOverall.TabIndex = 10;
            this.labelOverall.Text = "Overall:";
            // 
            // overallContent
            // 
            this.overallContent.AutoSize = true;
            this.overallContent.Location = new System.Drawing.Point(63, 189);
            this.overallContent.Name = "overallContent";
            this.overallContent.Size = new System.Drawing.Size(0, 13);
            this.overallContent.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.7533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.2467F));
            this.tableLayoutPanel1.Controls.Add(this.overallContent, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelOverall, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelDetails, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRandom, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelProtoss, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelZerg, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelTerran, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelRanked, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.randomContent, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.protossContent, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.zergContent, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.terranContent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.rankedContent, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(205, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 214);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelHumanPlayers
            // 
            this.labelHumanPlayers.AutoSize = true;
            this.labelHumanPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumanPlayers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelHumanPlayers.Location = new System.Drawing.Point(8, 77);
            this.labelHumanPlayers.Name = "labelHumanPlayers";
            this.labelHumanPlayers.Size = new System.Drawing.Size(48, 13);
            this.labelHumanPlayers.TabIndex = 1;
            this.labelHumanPlayers.Text = "Players";
            this.labelHumanPlayers.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(133, 325);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(72, 325);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(55, 23);
            this.buttonModify.TabIndex = 3;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(11, 325);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(55, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // checkedListBoxHumanPlayers
            // 
            this.checkedListBoxHumanPlayers.FormattingEnabled = true;
            this.checkedListBoxHumanPlayers.Location = new System.Drawing.Point(11, 105);
            this.checkedListBoxHumanPlayers.Name = "checkedListBoxHumanPlayers";
            this.checkedListBoxHumanPlayers.Size = new System.Drawing.Size(177, 214);
            this.checkedListBoxHumanPlayers.TabIndex = 5;
            this.checkedListBoxHumanPlayers.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxHumanPlayers_SelectedIndexChanged);
            // 
            // buttonCheckAll
            // 
            this.buttonCheckAll.Location = new System.Drawing.Point(23, 354);
            this.buttonCheckAll.Name = "buttonCheckAll";
            this.buttonCheckAll.Size = new System.Drawing.Size(69, 23);
            this.buttonCheckAll.TabIndex = 14;
            this.buttonCheckAll.Text = "Check All";
            this.buttonCheckAll.UseVisualStyleBackColor = true;
            this.buttonCheckAll.Click += new System.EventHandler(this.buttonCheckAll_Click);
            // 
            // buttonUncheckAll
            // 
            this.buttonUncheckAll.Location = new System.Drawing.Point(98, 354);
            this.buttonUncheckAll.Name = "buttonUncheckAll";
            this.buttonUncheckAll.Size = new System.Drawing.Size(79, 23);
            this.buttonUncheckAll.TabIndex = 15;
            this.buttonUncheckAll.Text = "Uncheck All";
            this.buttonUncheckAll.UseVisualStyleBackColor = true;
            this.buttonUncheckAll.Click += new System.EventHandler(this.buttonUncheckAll_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.githubToolStripMenuItem.Text = "Github";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(413, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(434, 877);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonUncheckAll);
            this.Controls.Add(this.buttonCheckAll);
            this.Controls.Add(this.buttonCreateTeamsManual);
            this.Controls.Add(this.richTextBoxTeams);
            this.Controls.Add(this.labelMarchResult);
            this.Controls.Add(this.labelCreateTeams);
            this.Controls.Add(this.labelParameters);
            this.Controls.Add(this.labelMatchmaking);
            this.Controls.Add(this.comboBoxWinningTeam);
            this.Controls.Add(this.comboBoxMatchType);
            this.Controls.Add(this.checkedListBoxHumanPlayers);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonCreateTeamsAuto);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelHumanPlayers);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SC 2 Matchmaker";
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
        private System.Windows.Forms.ComboBox comboBoxMatchType;
        private System.Windows.Forms.Button buttonCreateTeamsAuto;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.ComboBox comboBoxWinningTeam;
        private System.Windows.Forms.Label labelMatchmaking;
        private System.Windows.Forms.Label labelParameters;
        private System.Windows.Forms.Label labelMarchResult;
        private System.Windows.Forms.RichTextBox richTextBoxTeams;
        private System.Windows.Forms.Button buttonCreateTeamsManual;
        private System.Windows.Forms.Label labelCreateTeams;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectedModeToolStripMenuItem;
        private System.Windows.Forms.Label rankedContent;
        private System.Windows.Forms.Label terranContent;
        private System.Windows.Forms.Label zergContent;
        private System.Windows.Forms.Label protossContent;
        private System.Windows.Forms.Label randomContent;
        private System.Windows.Forms.Label labelRanked;
        private System.Windows.Forms.Label labelTerran;
        private System.Windows.Forms.Label labelZerg;
        private System.Windows.Forms.Label labelProtoss;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Label nameContent;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelOverall;
        private System.Windows.Forms.Label overallContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelHumanPlayers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.CheckedListBox checkedListBoxHumanPlayers;
        private System.Windows.Forms.Button buttonCheckAll;
        private System.Windows.Forms.Button buttonUncheckAll;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

