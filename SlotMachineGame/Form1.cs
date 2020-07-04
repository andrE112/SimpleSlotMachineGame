using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SlotMachineGame
{
    public partial class Form1 : Form
    {
        private Slot slot1;
        private Slot slot2;
        private Slot slot3;
        private int counter = 0;
        private int time=0;
        private string[] check= { "", "", "" };
        private int points = 100;
        private SoundPlayer background = new SoundPlayer(Properties.Resources.backgroundMusic);


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
            SoundPlayer clink = new SoundPlayer(Properties.Resources.clink);
            counter +=10;
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
                check[1]=slot2.Stop();
            }
            else
            {
                slot2.Update();
            }
            if (counter >= time * 3)
            {
                check[2] = slot3.Stop();
                btnSpin.Enabled = true;
                tmrSlot1.Stop();
                counter = 0;
                if(check[0]==check[1] && check[1] == check[2]){
                    SoundPlayer jackpot = new SoundPlayer(Properties.Resources.jackpot);
                    jackpot.Play();
                    MessageBox.Show("JACKPOT!");
                    background.PlayLooping();
                    points += 100;
                    pointsLabel.Text = "Points: " + points;
                }
                else
                {
                    //MessageBox.Show("NO JACKPOT!");
                    pointsLabel.Text = "Points: " + points;
                    if (points<=0){
                        SoundPlayer gameover = new SoundPlayer(Properties.Resources.gameOver);
                        gameover.Play();
                        MessageBox.Show("YOU RAN OUT OF POINTS!");
                        background.PlayLooping();
                        points = 100;
                        pointsLabel.Text = "Points: " + points;
                    }
                }
                for(int i = 0; i < 3; i++)
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
            background.PlayLooping();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            points -= 10;
            pointsLabel.Text = "Points: " + points;
            //SoundPlayer snd = new SoundPlayer(Properties.Resources.insertCoin);
            //snd.Play();
            Random rand = new Random();
            time = rand.Next(100, 1000);
            tmrSlot1.Start();
        }
    }
}
