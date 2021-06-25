namespace WifiPasscodeGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription1 = new System.Windows.Forms.Label();
            this.labelDescription2 = new System.Windows.Forms.Label();
            this.labelDescription3 = new System.Windows.Forms.Label();
            this.labelPlay = new System.Windows.Forms.Label();
            this.PlayColorTimer = new System.Windows.Forms.Timer(this.components);
            this.ClickDetectorTimer = new System.Windows.Forms.Timer(this.components);
            this.WifiButton = new System.Windows.Forms.Button();
            this.ButtonTimer = new System.Windows.Forms.Timer(this.components);
            this.EasyBTN = new System.Windows.Forms.Button();
            this.NormalBTN = new System.Windows.Forms.Button();
            this.GamerBTN = new System.Windows.Forms.Button();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.labelDiff = new System.Windows.Forms.Label();
            this.WinnersLabel = new System.Windows.Forms.Label();
            this.PasswordLabel1 = new System.Windows.Forms.Label();
            this.PasswordLabel2 = new System.Windows.Forms.Label();
            this.ESClabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(391, 118);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(472, 55);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Wifi Password Game";
            // 
            // labelDescription1
            // 
            this.labelDescription1.AutoSize = true;
            this.labelDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription1.ForeColor = System.Drawing.Color.White;
            this.labelDescription1.Location = new System.Drawing.Point(554, 208);
            this.labelDescription1.Name = "labelDescription1";
            this.labelDescription1.Size = new System.Drawing.Size(146, 36);
            this.labelDescription1.TabIndex = 1;
            this.labelDescription1.Text = "Welcome,";
            // 
            // labelDescription2
            // 
            this.labelDescription2.AutoSize = true;
            this.labelDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription2.ForeColor = System.Drawing.Color.White;
            this.labelDescription2.Location = new System.Drawing.Point(455, 285);
            this.labelDescription2.Name = "labelDescription2";
            this.labelDescription2.Size = new System.Drawing.Size(349, 36);
            this.labelDescription2.TabIndex = 2;
            this.labelDescription2.Text = "Want the Wifi Passcode?";
            // 
            // labelDescription3
            // 
            this.labelDescription3.AutoSize = true;
            this.labelDescription3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription3.ForeColor = System.Drawing.Color.White;
            this.labelDescription3.Location = new System.Drawing.Point(349, 336);
            this.labelDescription3.Name = "labelDescription3";
            this.labelDescription3.Size = new System.Drawing.Size(556, 36);
            this.labelDescription3.TabIndex = 3;
            this.labelDescription3.Text = "Simple, Just hit the Button and you got it!";
            // 
            // labelPlay
            // 
            this.labelPlay.AutoSize = true;
            this.labelPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlay.ForeColor = System.Drawing.Color.White;
            this.labelPlay.Location = new System.Drawing.Point(480, 620);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(314, 29);
            this.labelPlay.TabIndex = 4;
            this.labelPlay.Text = "Right click anywhere to Start";
            // 
            // PlayColorTimer
            // 
            this.PlayColorTimer.Enabled = true;
            this.PlayColorTimer.Interval = 700;
            this.PlayColorTimer.Tick += new System.EventHandler(this.PlayColorTimer_Tick);
            // 
            // ClickDetectorTimer
            // 
            this.ClickDetectorTimer.Enabled = true;
            this.ClickDetectorTimer.Tick += new System.EventHandler(this.ClickDetectorTimer_Tick);
            // 
            // WifiButton
            // 
            this.WifiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.WifiButton.Enabled = false;
            this.WifiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WifiButton.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WifiButton.Location = new System.Drawing.Point(527, 375);
            this.WifiButton.Name = "WifiButton";
            this.WifiButton.Size = new System.Drawing.Size(190, 80);
            this.WifiButton.TabIndex = 5;
            this.WifiButton.Text = "Wifi Password";
            this.WifiButton.UseVisualStyleBackColor = false;
            this.WifiButton.Visible = false;
            this.WifiButton.Click += new System.EventHandler(this.WifiButton_Click);
            // 
            // ButtonTimer
            // 
            this.ButtonTimer.Interval = 200;
            this.ButtonTimer.Tick += new System.EventHandler(this.ButtonTimer_Tick);
            // 
            // EasyBTN
            // 
            this.EasyBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EasyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyBTN.Location = new System.Drawing.Point(12, 239);
            this.EasyBTN.Name = "EasyBTN";
            this.EasyBTN.Size = new System.Drawing.Size(133, 55);
            this.EasyBTN.TabIndex = 6;
            this.EasyBTN.Text = "Noob";
            this.EasyBTN.UseVisualStyleBackColor = false;
            this.EasyBTN.Click += new System.EventHandler(this.EasyBTN_Click);
            // 
            // NormalBTN
            // 
            this.NormalBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NormalBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalBTN.Location = new System.Drawing.Point(12, 316);
            this.NormalBTN.Name = "NormalBTN";
            this.NormalBTN.Size = new System.Drawing.Size(133, 55);
            this.NormalBTN.TabIndex = 7;
            this.NormalBTN.Text = "Normal";
            this.NormalBTN.UseVisualStyleBackColor = false;
            this.NormalBTN.Click += new System.EventHandler(this.NormalBTN_Click);
            // 
            // GamerBTN
            // 
            this.GamerBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GamerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GamerBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamerBTN.Location = new System.Drawing.Point(12, 395);
            this.GamerBTN.Name = "GamerBTN";
            this.GamerBTN.Size = new System.Drawing.Size(133, 55);
            this.GamerBTN.TabIndex = 8;
            this.GamerBTN.Text = "Gamer";
            this.GamerBTN.UseVisualStyleBackColor = false;
            this.GamerBTN.Click += new System.EventHandler(this.GamerBTN_Click);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DifficultyLabel.Location = new System.Drawing.Point(6, 9);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(175, 32);
            this.DifficultyLabel.TabIndex = 9;
            this.DifficultyLabel.Text = "0.2s | 200ms";
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiff.ForeColor = System.Drawing.Color.White;
            this.labelDiff.Location = new System.Drawing.Point(12, 189);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(124, 32);
            this.labelDiff.TabIndex = 10;
            this.labelDiff.Text = "Difficulty";
            // 
            // WinnersLabel
            // 
            this.WinnersLabel.AutoSize = true;
            this.WinnersLabel.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnersLabel.ForeColor = System.Drawing.Color.White;
            this.WinnersLabel.Location = new System.Drawing.Point(88, 153);
            this.WinnersLabel.Name = "WinnersLabel";
            this.WinnersLabel.Size = new System.Drawing.Size(1053, 55);
            this.WinnersLabel.TabIndex = 11;
            this.WinnersLabel.Text = "Congrats Hitting The Button on Normal Difficulty!";
            this.WinnersLabel.Visible = false;
            // 
            // PasswordLabel1
            // 
            this.PasswordLabel1.AutoSize = true;
            this.PasswordLabel1.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel1.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel1.Location = new System.Drawing.Point(412, 281);
            this.PasswordLabel1.Name = "PasswordLabel1";
            this.PasswordLabel1.Size = new System.Drawing.Size(472, 55);
            this.PasswordLabel1.TabIndex = 12;
            this.PasswordLabel1.Text = "The Wifi Password Is";
            this.PasswordLabel1.Visible = false;
            // 
            // PasswordLabel2
            // 
            this.PasswordLabel2.AutoSize = true;
            this.PasswordLabel2.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PasswordLabel2.Location = new System.Drawing.Point(492, 352);
            this.PasswordLabel2.Name = "PasswordLabel2";
            this.PasswordLabel2.Size = new System.Drawing.Size(291, 55);
            this.PasswordLabel2.TabIndex = 13;
            this.PasswordLabel2.Text = "53281abcde";
            this.PasswordLabel2.Visible = false;
            // 
            // ESClabel
            // 
            this.ESClabel.AutoSize = true;
            this.ESClabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESClabel.ForeColor = System.Drawing.Color.White;
            this.ESClabel.Location = new System.Drawing.Point(541, 675);
            this.ESClabel.Name = "ESClabel";
            this.ESClabel.Size = new System.Drawing.Size(201, 29);
            this.ESClabel.TabIndex = 14;
            this.ESClabel.Text = "Press ESC to Exit";
            this.ESClabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1252, 753);
            this.Controls.Add(this.ESClabel);
            this.Controls.Add(this.PasswordLabel2);
            this.Controls.Add(this.PasswordLabel1);
            this.Controls.Add(this.WinnersLabel);
            this.Controls.Add(this.labelDiff);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.GamerBTN);
            this.Controls.Add(this.NormalBTN);
            this.Controls.Add(this.EasyBTN);
            this.Controls.Add(this.WifiButton);
            this.Controls.Add(this.labelPlay);
            this.Controls.Add(this.labelDescription3);
            this.Controls.Add(this.labelDescription2);
            this.Controls.Add(this.labelDescription1);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1270, 800);
            this.MinimumSize = new System.Drawing.Size(1270, 800);
            this.Name = "Form1";
            this.Text = "The Wifi Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription1;
        private System.Windows.Forms.Label labelDescription2;
        private System.Windows.Forms.Label labelDescription3;
        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.Timer PlayColorTimer;
        private System.Windows.Forms.Timer ClickDetectorTimer;
        private System.Windows.Forms.Button WifiButton;
        private System.Windows.Forms.Timer ButtonTimer;
        private System.Windows.Forms.Button EasyBTN;
        private System.Windows.Forms.Button NormalBTN;
        private System.Windows.Forms.Button GamerBTN;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.Label WinnersLabel;
        private System.Windows.Forms.Label PasswordLabel1;
        private System.Windows.Forms.Label PasswordLabel2;
        private System.Windows.Forms.Label ESClabel;
    }
}

