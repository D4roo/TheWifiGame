using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiPasscodeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void PlayColorTimer_Tick(object sender, EventArgs e)
        {
            if (this.labelPlay.ForeColor == Color.Purple)       //Color Change Play Label
            {
                this.labelPlay.ForeColor = Color.Green;
            }
            else if (this.labelPlay.ForeColor == Color.Green)
            {
                this.labelPlay.ForeColor = Color.White;
            }
            else if (this.labelPlay.ForeColor == Color.White)
            {
                this.labelPlay.ForeColor = Color.Purple;
            }
        }

        private void ClickDetectorTimer_Tick(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                ClickDetectorTimer.Enabled = false;       //Turn Off All UI's
                PlayColorTimer.Enabled = false;
                labelName.Visible = false;
                labelDescription1.Visible = false;
                labelDescription2.Visible = false;
                labelDescription3.Visible = false;
                labelPlay.Visible = false;

                ButtonTimer.Enabled = true;       //Enable Moving Wifi Button
                WifiButton.Visible = true;
                WifiButton.Enabled = true;

                EasyBTN.Enabled = false;       //Turn Off Difficulty Buttons
                NormalBTN.Enabled = false;
                GamerBTN.Enabled = false;
                EasyBTN.Visible = false;
                NormalBTN.Visible = false;
                GamerBTN.Visible = false;
                labelDiff.Visible = false;
            }
        }

        private void WifiButton_Click(object sender, EventArgs e)
        {
            ButtonTimer.Enabled = false;       //You Won Function
            WinnersLabel.Visible = true;
            PasswordLabel1.Visible = true;
            PasswordLabel2.Visible = true;
            ESClabel.Visible = true;
        }

        private void ButtonTimer_Tick(object sender, EventArgs e)
        {
            if (MousePosition.X >= WifiButton.Location.X)     //Make The Button Move And Stay On Screen
            {

                Random x = new Random();
                Point newXY = new Point(int.Parse(x.Next(850).ToString()), int.Parse(x.Next(550).ToString()));
                WifiButton.Location = newXY;
            }
        }
        private void EasyBTN_Click(object sender, EventArgs e)
        {
            DifficultyLabel.Text = ("0.3s | 300ms");       //Noob Difficulty
            DifficultyLabel.ForeColor = Color.LightGreen;
            ButtonTimer.Interval = 300;
            WinnersLabel.Text = ("Congrats Hitting The Button on Noob Difficulty!");
        }

        private void NormalBTN_Click(object sender, EventArgs e)
        {
            DifficultyLabel.Text = ("0.2s | 200ms");       //Normal Difficulty
            DifficultyLabel.ForeColor = Color.Orange;
            ButtonTimer.Interval = 200;
            WinnersLabel.Text = ("Congrats Hitting The Button on Normal Difficulty!");

        }

        private void GamerBTN_Click(object sender, EventArgs e)
        {
            DifficultyLabel.Text = ("0.1s | 100ms");       //Gamer Difficulty
            DifficultyLabel.ForeColor = Color.Red;
            ButtonTimer.Interval = 100;
            WinnersLabel.Text = ("Congrats Hitting The Button on Gamer Difficulty!");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Space)
            {
                PasswordLabel2.Text = ("Cheater LOL LMAO NOOOOOB");
            }
        }

    }
}