﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.CompilerServices;

namespace SlotMachineGame
{
    public partial class Form1 : Form
    {
        private Slot slot1;
        private Slot slot2;
        private Slot slot3;
        private int counter = 0;
        private int time = 0;
        private string[] check = { "", "", "" };
        private int points = 100;
        private int highscore;
        private int bet = 10;
        private SoundPlayer background = new SoundPlayer(Properties.Resources.backgroundMusic);
        private string fileName = System.AppDomain.CurrentDomain.BaseDirectory + @"scores.bin";


        public Form1()
        {
            InitializeComponent();
            slot1 = new Slot(pictureBox1, pictureBox2);
            slot2 = new Slot(pictureBox3, pictureBox4);
            slot3 = new Slot(pictureBox5, pictureBox6);
        }

        private void tmrSlot1_Tick(object sender, EventArgs e)
        {
            btnSpin.Enabled = false;
            betBox.Enabled = false;
            SoundPlayer clink = new SoundPlayer(Properties.Resources.clink);
            counter += 10;
            if (counter >= time)
            {
                check[0] = slot1.Stop();
            }
            else
            {
                slot1.Update();
            }
            if (counter >= time * 2)
            {
                check[1] = slot2.Stop();
            }
            else
            {
                slot2.Update();
            }
            if (counter >= time * 3)
            {
                check[2] = slot3.Stop();
                btnSpin.Enabled = true;
                betBox.Enabled = true;
                tmrSlot1.Stop();
                counter = 0;
                if (check[0] == check[1] && check[1] == check[2])
                {
                    SoundPlayer jackpot = new SoundPlayer(Properties.Resources.jackpot);
                    jackpot.Play();
                    MessageBox.Show("JACKPOT!");
                    background.PlayLooping();
                    Score();
                    pointsLabel.Text = "Points: " + points;
                }
                else
                {
                    pointsLabel.Text = "Points: " + points;
                    if (points <= 0)
                    {
                        SoundPlayer gameover = new SoundPlayer(Properties.Resources.gameOver);
                        gameover.Play();
                        MessageBox.Show("YOU RAN OUT OF POINTS!");
                        WriteHighScore();
                        DisplayNewHighScore();
                        background.PlayLooping();
                        points = 100;
                        pointsLabel.Text = "Points: " + points;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    check[i] = "";
                }
            }
            else
            {
                slot3.Update();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
            background.PlayLooping();
            DisplayHighScore();

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            bet = int.Parse(betBox.Text);
            if (bet > points)
            {
                MessageBox.Show("You can't bet more points than what you have! Change your bet.");
            }
            else
            {
                if (points > highscore)
                {
                    highscore = points;
                }
                points -= bet;
                pointsLabel.Text = "Points: " + points;
                Random rand = new Random();
                time = rand.Next(100, 1000);
                tmrSlot1.Start();
            }
        }

        private void Score()
        {
            if (check[0] == "Seven")
            {
                points += bet * 2;
            }
            else if (check[0] == "Diamond")
            {
                points += Convert.ToInt32(bet * 1.5);
            }
            else
            {
                points += Convert.ToInt32(10 * 1.25);
            }
        }

        public void WriteHighScore()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(highscore);
            }
        }

        public void DisplayHighScore()
        {
            int highscoreRead;

            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    highscoreRead = reader.ReadInt32();
                }

                    labelHighscore.Text = "HighScore: " + highscoreRead;
                    highscore = highscoreRead;
            }
        }

        public void DisplayNewHighScore()
        {
            int highscoreRead;

            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    highscoreRead = reader.ReadInt32();
                }

                if (highscoreRead >= highscore)
                {
                    highscore = highscoreRead;
                    labelHighscore.Text = "HighScore: " + highscoreRead;
                }
            }
        }
    }
}
