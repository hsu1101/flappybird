using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybird
{

    public partial class Form1 : Form
    {
        bool game = false;
      
        public Form1()
        {
            InitializeComponent();
           
            this.DoubleBuffered = true;//減少閃爍
            label1.Visible = false;

        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (game == true)
            {
                movetree(5);//移動樹
                movepillar(5);//移動柱子
                gameover();
            }

        }

        void movetree(int speed)//移動樹的method，speed為移動樹的速度
        {
            if (game == true)
            {
                if (t1.Left >= 0)
                {
                    t1.Left += -speed;
                }
                else
                {
                    t1.Left = 880;
                }
                if (t2.Left >= 0)
                {
                    t2.Left += -speed;
                }
                else
                {
                    t2.Left = 880;
                }
                if (t3.Left >= 0)
                {
                    t3.Left += -speed;
                }
                else
                {
                    t3.Left = 880;
                }
            }
        }
        Random r = new Random();
        void movepillar(int speed)
        {
            if (game == true)
            {
                if (h1.Left >= 0)
                {
                    h1.Left += -speed;
                }
                else
                {
                    h1.Left = 880;
                    h1.Height = r.Next(275, 325);
                }
                if (h2.Left >= 0)
                {
                    h2.Left += -speed;
                }
                else
                {
                    h2.Left = 880;
                    h2.Height = r.Next(150, 200);
                }
                if (h3.Left >= 0)
                {
                    h3.Left += -speed;
                }
                else
                {
                    h3.Left = 880;
                    h3.Height = r.Next(275, 325);
                }
                if (h4.Left >= 0)
                {
                    h4.Left += -speed;
                }
                else
                {
                    h4.Left = 880;
                    h4.Height = r.Next(150, 200);
                }
                if (h5.Left >= 0)
                {
                    h5.Left += -speed;
                }
                else
                {
                    h5.Left = 880;
                    h5.Height = r.Next(275, 300);
                }
                if (h6.Left >= 0)
                {
                    h6.Left += -speed;
                }
                else
                {
                    h6.Left = 880;
                    h6.Height = r.Next(200, 250);
                }
                if (h7.Left >= 0)
                {
                    h7.Left += -speed;
                }
                else
                {
                    h7.Left = 880;
                    h7.Height = r.Next(250, 300);
                }
                if (h8.Left >= 0)
                {
                    h8.Left += -speed;
                }
                else
                {
                    h8.Left = 880;
                    h8.Height = r.Next(150, 200);
                }
            }
        }
        int score = 0;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (game == true)
            {
                if (bird.Top <= 420)
                {
                    bird.Top += 2;
                    score++;
                   
                    label2.Text = score.ToString();
                }
            }
        }
      

        void gameover()
        {
            if (game == true)
            {
                if (bird.Bounds.IntersectsWith(h1.Bounds) || bird.Bounds.IntersectsWith(h2.Bounds) || bird.Bounds.IntersectsWith(h3.Bounds) ||
                bird.Bounds.IntersectsWith(h4.Bounds) || bird.Bounds.IntersectsWith(h5.Bounds) || bird.Bounds.IntersectsWith(h6.Bounds) ||
                bird.Bounds.IntersectsWith(h7.Bounds) || bird.Bounds.IntersectsWith(h8.Bounds))
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                   
                    label1.Visible = true;
                    replay.Enabled = true;
                    replay.Visible = true;
                    game =false;
                 
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (game == true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    bird.Top += -15;
                }
            }
        }


      

        private void Button1_Click(object sender, EventArgs e) 
        {
            game = true;
            start.Visible = false;
            start.Enabled  = false;
           
        }

        private void Replay_Click(object sender, EventArgs e)
        {
            game = true;
            label1.Visible = false;
            replay.Enabled = false;
            replay.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            score = 0;
          
            if (bird.Bounds.IntersectsWith(h1.Bounds) || bird.Bounds.IntersectsWith(h3.Bounds) ||
              bird.Bounds.IntersectsWith(h5.Bounds) ||   bird.Bounds.IntersectsWith(h7.Bounds) )
            {
                bird.Top += -35;

            }
           if ( bird.Bounds.IntersectsWith(h2.Bounds) ||bird.Bounds.IntersectsWith(h4.Bounds) || bird.Bounds.IntersectsWith(h6.Bounds) ||
              bird.Bounds.IntersectsWith(h8.Bounds))
            {
                bird.Top += 35;

            }


        }
       
       
       



    }
}
    
