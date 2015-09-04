namespace sc2_matchmaker
{
    partial class TeamForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonTerran = new System.Windows.Forms.RadioButton();
            this.radioButtonZerg = new System.Windows.Forms.RadioButton();
            this.radioButtonProtoss = new System.Windows.Forms.RadioButton();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.numericUpDownTeam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelHumanPlayers = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(199, 183);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = ">>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioButtonTerran
            // 
            this.radioButtonTerran.AutoSize = true;
            this.radioButtonTerran.Location = new System.Drawing.Point(199, 52);
            this.radioButtonTerran.Name = "radioButtonTerran";
            this.radioButtonTerran.Size = new System.Drawing.Size(56, 17);
            this.radioButtonTerran.TabIndex = 2;
            this.radioButtonTerran.TabStop = true;
            this.radioButtonTerran.Text = "Terran";
            this.radioButtonTerran.UseVisualStyleBackColor = true;
            this.radioButtonTerran.CheckedChanged += new System.EventHandler(this.radioButtonTerran_CheckedChanged);
            // 
            // radioButtonZerg
            // 
            this.radioButtonZerg.AutoSize = true;
            this.radioButtonZerg.Location = new System.Drawing.Point(199, 75);
            this.radioButtonZerg.Name = "radioButtonZerg";
            this.radioButtonZerg.Size = new System.Drawing.Size(47, 17);
            this.radioButtonZerg.TabIndex = 2;
            this.radioButtonZerg.TabStop = true;
            this.radioButtonZerg.Text = "Zerg";
            this.radioButtonZerg.UseVisualStyleBackColor = true;
            this.radioButtonZerg.CheckedChanged += new System.EventHandler(this.radioButtonZerg_CheckedChanged);
            // 
            // radioButtonProtoss
            // 
            this.radioButtonProtoss.AutoSize = true;
            this.radioButtonProtoss.Location = new System.Drawing.Point(199, 98);
            this.radioButtonProtoss.Name = "radioButtonProtoss";
            this.radioButtonProtoss.Size = new System.Drawing.Size(60, 17);
            this.radioButtonProtoss.TabIndex = 2;
            this.radioButtonProtoss.TabStop = true;
            this.radioButtonProtoss.Text = "Protoss";
            this.radioButtonProtoss.UseVisualStyleBackColor = true;
            this.radioButtonProtoss.CheckedChanged += new System.EventHandler(this.radioButtonProtoss_CheckedChanged);
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(199, 121);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(65, 17);
            this.radioButtonRandom.TabIndex = 2;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Random";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.CheckedChanged += new System.EventHandler(this.radioButtonRandom_CheckedChanged);
            // 
            // numericUpDownTeam
            // 
            this.numericUpDownTeam.Location = new System.Drawing.Point(236, 144);
            this.numericUpDownTeam.Name = "numericUpDownTeam";
            this.numericUpDownTeam.Size = new System.Drawing.Size(61, 20);
            this.numericUpDownTeam.TabIndex = 3;
            this.numericUpDownTeam.ValueChanged += new System.EventHandler(this.numericUpDownTeam_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(358, 254);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(68, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(432, 254);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(68, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelHumanPlayers
            // 
            this.labelHumanPlayers.AutoSize = true;
            this.labelHumanPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumanPlayers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelHumanPlayers.Location = new System.Drawing.Point(9, 9);
            this.labelHumanPlayers.Name = "labelHumanPlayers";
            this.labelHumanPlayers.Size = new System.Drawing.Size(118, 13);
            this.labelHumanPlayers.TabIndex = 7;
            this.labelHumanPlayers.Text = "Unassigned Players";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(319, 36);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(181, 199);
            this.listBox2.TabIndex = 8;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(199, 212);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(114, 23);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "<<";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(316, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Assigned Players";
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 287);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHumanPlayers);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownTeam);
            this.Controls.Add(this.radioButtonRandom);
            this.Controls.Add(this.radioButtonProtoss);
            this.Controls.Add(this.radioButtonZerg);
            this.Controls.Add(this.radioButtonTerran);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBox1);
            this.Name = "TeamForm";
            this.Text = "Manual Team Creation";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioButtonTerran;
        private System.Windows.Forms.RadioButton radioButtonZerg;
        private System.Windows.Forms.RadioButton radioButtonProtoss;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.NumericUpDown numericUpDownTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelHumanPlayers;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label2;
    }
}