namespace sc2_matchmaker
{
    partial class PlayerForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBoxTerran = new System.Windows.Forms.CheckBox();
            this.checkBoxZerg = new System.Windows.Forms.CheckBox();
            this.checkBoxProtoss = new System.Windows.Forms.CheckBox();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.labelSelectRaces = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxTerran = new System.Windows.Forms.ComboBox();
            this.comboBoxZerg = new System.Windows.Forms.ComboBox();
            this.comboBoxProtoss = new System.Windows.Forms.ComboBox();
            this.comboBoxRandom = new System.Windows.Forms.ComboBox();
            this.labelEstimatedLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(53, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(107, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // checkBoxTerran
            // 
            this.checkBoxTerran.AutoSize = true;
            this.checkBoxTerran.Location = new System.Drawing.Point(15, 80);
            this.checkBoxTerran.Name = "checkBoxTerran";
            this.checkBoxTerran.Size = new System.Drawing.Size(57, 17);
            this.checkBoxTerran.TabIndex = 2;
            this.checkBoxTerran.Text = "Terran";
            this.checkBoxTerran.UseVisualStyleBackColor = true;
            // 
            // checkBoxZerg
            // 
            this.checkBoxZerg.AutoSize = true;
            this.checkBoxZerg.Location = new System.Drawing.Point(15, 103);
            this.checkBoxZerg.Name = "checkBoxZerg";
            this.checkBoxZerg.Size = new System.Drawing.Size(48, 17);
            this.checkBoxZerg.TabIndex = 2;
            this.checkBoxZerg.Text = "Zerg";
            this.checkBoxZerg.UseVisualStyleBackColor = true;
            // 
            // checkBoxProtoss
            // 
            this.checkBoxProtoss.AutoSize = true;
            this.checkBoxProtoss.Location = new System.Drawing.Point(15, 126);
            this.checkBoxProtoss.Name = "checkBoxProtoss";
            this.checkBoxProtoss.Size = new System.Drawing.Size(61, 17);
            this.checkBoxProtoss.TabIndex = 2;
            this.checkBoxProtoss.Text = "Protoss";
            this.checkBoxProtoss.UseVisualStyleBackColor = true;
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(15, 149);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(66, 17);
            this.checkBoxRandom.TabIndex = 2;
            this.checkBoxRandom.Text = "Random";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            // 
            // labelSelectRaces
            // 
            this.labelSelectRaces.AutoSize = true;
            this.labelSelectRaces.Location = new System.Drawing.Point(12, 54);
            this.labelSelectRaces.Name = "labelSelectRaces";
            this.labelSelectRaces.Size = new System.Drawing.Size(117, 13);
            this.labelSelectRaces.TabIndex = 1;
            this.labelSelectRaces.Text = "Select Playable Races:";
            this.labelSelectRaces.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(230, 178);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(149, 178);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxTerran
            // 
            this.comboBoxTerran.FormattingEnabled = true;
            this.comboBoxTerran.Location = new System.Drawing.Point(207, 76);
            this.comboBoxTerran.Name = "comboBoxTerran";
            this.comboBoxTerran.Size = new System.Drawing.Size(98, 21);
            this.comboBoxTerran.TabIndex = 4;
            // 
            // comboBoxZerg
            // 
            this.comboBoxZerg.FormattingEnabled = true;
            this.comboBoxZerg.Location = new System.Drawing.Point(207, 99);
            this.comboBoxZerg.Name = "comboBoxZerg";
            this.comboBoxZerg.Size = new System.Drawing.Size(98, 21);
            this.comboBoxZerg.TabIndex = 5;
            // 
            // comboBoxProtoss
            // 
            this.comboBoxProtoss.FormattingEnabled = true;
            this.comboBoxProtoss.Location = new System.Drawing.Point(207, 122);
            this.comboBoxProtoss.Name = "comboBoxProtoss";
            this.comboBoxProtoss.Size = new System.Drawing.Size(98, 21);
            this.comboBoxProtoss.TabIndex = 6;
            // 
            // comboBoxRandom
            // 
            this.comboBoxRandom.FormattingEnabled = true;
            this.comboBoxRandom.Location = new System.Drawing.Point(207, 145);
            this.comboBoxRandom.Name = "comboBoxRandom";
            this.comboBoxRandom.Size = new System.Drawing.Size(98, 21);
            this.comboBoxRandom.TabIndex = 7;
            // 
            // labelEstimatedLevel
            // 
            this.labelEstimatedLevel.AutoSize = true;
            this.labelEstimatedLevel.Location = new System.Drawing.Point(204, 54);
            this.labelEstimatedLevel.Name = "labelEstimatedLevel";
            this.labelEstimatedLevel.Size = new System.Drawing.Size(85, 13);
            this.labelEstimatedLevel.TabIndex = 8;
            this.labelEstimatedLevel.Text = "Estimated Level:";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 213);
            this.Controls.Add(this.labelEstimatedLevel);
            this.Controls.Add(this.comboBoxRandom);
            this.Controls.Add(this.comboBoxProtoss);
            this.Controls.Add(this.comboBoxZerg);
            this.Controls.Add(this.comboBoxTerran);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxRandom);
            this.Controls.Add(this.checkBoxProtoss);
            this.Controls.Add(this.checkBoxZerg);
            this.Controls.Add(this.checkBoxTerran);
            this.Controls.Add(this.labelSelectRaces);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "PlayerForm";
            this.Text = "Player Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox checkBoxTerran;
        private System.Windows.Forms.CheckBox checkBoxZerg;
        private System.Windows.Forms.CheckBox checkBoxProtoss;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.Label labelSelectRaces;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxTerran;
        private System.Windows.Forms.ComboBox comboBoxZerg;
        private System.Windows.Forms.ComboBox comboBoxProtoss;
        private System.Windows.Forms.ComboBox comboBoxRandom;
        private System.Windows.Forms.Label labelEstimatedLevel;
    }
}