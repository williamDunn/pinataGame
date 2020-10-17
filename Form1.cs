//William Dunn - 275 - Assignment 9 / Pinata Game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private List<Pinata> pinatas;
        private List<Bat> bats;

        private Brush circleBrush;

        public Form1()
        {
            InitializeComponent();

            pinatas = new List<Pinata>();
            bats = new List<Bat>();

            circleBrush = new SolidBrush(Color.Black);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pinatas.Add(new Pinata(new Point(220, 0), 0));

            bats.Add(new Bat(new Point(340, 390), -20));

          //  pinatas[0].Revolution += Form1_Revolution;
        }

        //private void Form1_Revolution(object sender, EventArgs e)
        //{
        //    int revolutions = int.Parse(tsslRevolutions.Text);
        //    revolutions++;
        //    tsslRevolutions.Text = revolutions.ToString();
        //}

        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    foreach (Pinata pinata in pinatas)
        //    {
        //        pinata.Move();
        //    }
        //    this.Refresh();
        //}

        int currentScore = 0;
        int highScore = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!pause)
            {
                foreach (Pinata pinata in pinatas)
                {
                    pinata.Move();
                    if (swing)
                    {
                        foreach(Bat bat in bats)
                        {
                            bat.move();
                            if (!bat.swinging())
                            {
                                swing = false;
                            }
                            if (bat.isCollision(pinata))
                            {
                                pinata.hit();
                                currentScore++;
                                
                            }
                        }
                    }
                }
            }
            if(currentScore >= highScore)
            {
                highScore = currentScore;
            }
            tsslHighScore.Text = highScore.ToString();
            tsslCurrent.Text = currentScore.ToString();
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Pinata pinata in pinatas)
            {
                pinata.Draw(e.Graphics);
            }
            foreach(Bat bat in bats)
            {
                bat.draw(e.Graphics);
            }
        }


        bool pause = false;
        bool swing = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if(e.KeyCode == Keys.Space)
                {
                    swing = true;
                }
                
            }

            if (e.KeyCode == Keys.P)
            {
                swing = false;
                pause = !pause;

            }
        }

        private void loseGame()
        {
            MessageBox.Show("You missed! (clicked reset)");
            foreach (Pinata pinata in pinatas)
            {
                pinata.reset();
            }
            currentScore = 0;
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            loseGame();
        }
    }
}
