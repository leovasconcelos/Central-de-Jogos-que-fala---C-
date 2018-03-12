using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
namespace game
{
    public partial class Form1 : Form
    {
        Loura L = new Loura();
        List<sheep> sheeps = new List<sheep>();
        List<chicken> chickens = new List<chicken>();
        Random rnd = new Random();
        int time=90;
        int locY=70;
        int sheepsIndex;
        int chickensIndex;
        int MYscore;
        int SheepCurrY;
        int chickenCurrY=0;
        int Level;
        int RndNumSheep;
        int TmpLoura;
        string picPath1,picPath2;
        bool pause=false;
        string game;
        int endCounter;
        SoundPlayer sheepS = new SoundPlayer();
        SoundPlayer chickenS = new SoundPlayer();

        SoundPlayer sheepSf = new SoundPlayer();
        SoundPlayer chickenSf = new SoundPlayer();
        public Form1()
        {
            sheepS.SoundLocation = "..\\maa2.wav";
            chickenS.SoundLocation = "..\\coc.wav";
            sheepS.Load();
            chickenS.Load();
            sheepSf.SoundLocation = "..\\maaa2.wav";
            chickenSf.SoundLocation = "..\\cock.wav";
            sheepS.Load();
            chickenS.Load();
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach(sheep s in sheeps)
                g.DrawImage(s.I, new Point(s.x,s.y));
            foreach (chicken c in chickens)
                g.DrawImage(c.I, new Point(c.x, c.y));
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyData.ToString() == "Down")
                {
                    if (locY < 475 - pictureBox1.Size.Height)
                    {
                        pictureBox1.Location = new Point(0, locY + 10);
                        locY += 10;
                    }
                }
                else if (e.KeyData.ToString() == "Up")
                {
                    if (locY > 70)
                    {
                        pictureBox1.Location = new Point(0, locY - 10);
                        locY -= 10;
                    }
                }
                int flag = 0;
                foreach (sheep s in sheeps)
                {
                    if (s.x < 15)
                    {
                        flag = score(s.y, true);
                        sheeps.Remove(s);
                        break;
                    }

                    else if (s.x < 45)
                    {
                        flag = score(s.y, true);
                        if (flag == 1)
                        {
                            sheeps.Remove(s);
                            break;
                        }
                    }
                }
                flag = 0;
                foreach (chicken c in chickens)
                {
                    if (c.x < 15)
                    {
                        flag = score(c.y, false);
                        chickens.Remove(c);
                        break;
                    }
                    else if (c.x < 45)
                    {
                        flag = score(c.y, false);
                        if (flag == 2)
                        {
                            chickens.Remove(c);
                            break;
                        }
                    }
                }
                Invalidate();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time != 0)
            {
                moveRight();
                if ((rnd.Next(0, 10000) < RndNumSheep))
                {
                    newSheep();
                }
                else
                {
                    newChicken();
                }
            }
            else
            {
                congratulations();
                if (MYscore >= 0 && game == "ovelha")
                    sheepSf.Play();
                else if (game == "sheep") chickenSf.Play();
                //newGameToolStripMenuItem_Click(sender, e);
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = true;
                label8.Visible = true;
            }
            this.Invalidate();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        void moveRight()
        {
            int flag = 0;
            foreach (sheep s in sheeps)
            {
                s.x -= 50;
                if (s.x < 15)
                {
                    flag = score(s.y, true);
                    sheeps.Remove(s);
                    moveRightSheep2();
                    break; 
                }
                
                else if (s.x<45)
                {
                    flag = score(s.y, true);
                    if (flag == 1)
                    {
                        sheeps.Remove(s);
                        moveRightSheep2();
                        break;
                    }
                }
            }
            flag = 0;
            Invalidate();
            foreach (chicken c in chickens)
            {
                c.x -= 50;
                if (c.x < 15)
                {
                    flag = score(c.y, false);
                    chickens.Remove(c);
                    moveRightChicken2();
                    break;
                }
                else if (c.x < 45)
                {
                    flag = score(c.y, false);
                    if (flag == 2)
                    {
                        chickens.Remove(c);
                        moveRightChicken2();
                        break;
                    }
                }
            }
            Invalidate();
        }
        void newSheep()
        {
            sheep s = new sheep(picPath1);
            s.index=sheepsIndex++;
            s.x = 570;
            s.y = rnd.Next(70, 475 - pictureBox1.Size.Height);
            SheepCurrY = s.y;
            sheeps.Add(s);
        }
        void newChicken()
        {
            chicken c = new chicken(picPath2);
            c.index = chickensIndex++;
            c.x = 570;
            for (; ; )
            {
                c.y = rnd.Next(70, 475 - pictureBox1.Size.Height);
                if (checkIfExistIcon(c.y))
                    break;
            }
            chickens.Add(c);
        }
        bool checkIfExistIcon(int y)
        {
            bool b1=true;
            if (Math.Abs(SheepCurrY - y) < 50)
                b1 = false;
            return b1;
        }
        bool checkIfExistChicken(int y)
        {
            bool b1 = true;
            if (Math.Abs(chickenCurrY - y) < 50)
                b1 = false;
            return b1;
        }
        int score(int y,bool sheep)
        {
            int flag=0;
            if ( sheep && (Math.Abs(pictureBox1.Location.Y - y) < 45))
            {
                MYscore += 10;
                label2.Text = MYscore.ToString();
                flag = 1;
                if (game == "ovelha")
                    sheepS.Play();
            }
            else if (!sheep && (Math.Abs(pictureBox1.Location.Y - y) < 45))
            {
                MYscore -= 10;
                label2.Text = MYscore.ToString();
                flag = 2;
                if(game=="ovelha")
                    chickenS.Play();
            }
            else { flag = 0; }
            return flag;
        }
        void moveRightSheep2()
        {
            foreach (sheep s in sheeps)
            {
                s.x -= 50;
            }
        }
        void moveRightChicken2()
        {
               foreach (chicken c in chickens)
                {
                     c.x -= 50;
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
        }
        private void l1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Level = 1;
            level();
            l1ToolStripMenuItem.Checked = true;
            level2ToolStripMenuItem.Checked = false;
            level3ToolStripMenuItem.Checked = false;
        }
        void level()
        {
            if (Level == 1)
            {
                RndNumSheep = 5000;
                timer1.Interval = 1000;
            }
            if (Level == 2)
            {
                RndNumSheep =3000;
                timer1.Interval = 750;
            }
            if (Level == 3)
            {
                RndNumSheep = 1000;
                timer1.Interval = 300;
            }
        }
        private void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Level = 2;
            level();
            l1ToolStripMenuItem.Checked = false;
            level2ToolStripMenuItem.Checked = true;
            level3ToolStripMenuItem.Checked = false;
        }
        private void level3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Level = 3;
            level();
            l1ToolStripMenuItem.Checked = false;
            level2ToolStripMenuItem.Checked = false;
            level3ToolStripMenuItem.Checked = true;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            time--;
            label3.Text = time.ToString();
        }
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (timer1.Enabled && time<90 && time>0)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    TmpLoura = pictureBox1.Location.Y;
                    pictureBox1.Visible = false;
                    pause = true;
                }
                else if(time<90 && time>0)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Location = new Point(0, TmpLoura);
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    pause = false;
                }

        }
        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newGame();
            picPath1 = @"..\\sheep.jpg";
            picPath2 = @"..\\chicken.jpg";
            game = "ovelha";
            newGameToolStripMenuItem1.Checked = true;
            whiteBearVSBlackBearToolStripMenuItem.Checked = false;
            rabbitVSPenguinToolStripMenuItem.Checked = false;
        }
        void newGame()
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = false;
            sheeps.Clear();
            chickens.Clear();
            label2.Text = "0";
            label3.Text = "90";
            MYscore = 0;
            time = 90;
            Level = 1;
            level();
            RndNumSheep = 5000;
            pause = false;
            l1ToolStripMenuItem.Checked = true;
            level2ToolStripMenuItem.Checked = false;
            level3ToolStripMenuItem.Checked = false;
            endCounter = 0;
            sheepSf.Stop();
            chickenSf.Stop();
            locY = 70;
            pictureBox1.Location = new Point(0, 70);
            pictureBox1.Visible = true;
            label8.Visible = false;
        }
        private void whiteBearVSBlackBearToolStripMenuItem_Click(object sender, EventArgs e)
        {

            newGameToolStripMenuItem1.Checked = false;
            whiteBearVSBlackBearToolStripMenuItem.Checked = true;
            rabbitVSPenguinToolStripMenuItem.Checked = false;
            newGame();
            picPath1 = @"..\\Obear.jpg";
            picPath2 = @"..\\Bbear.jpg";
            game = "ursos";
            this.Text = "Pegue as peras laranjas";
        }
        private void rabbitVSPenguinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGameToolStripMenuItem1.Checked = false;
            whiteBearVSBlackBearToolStripMenuItem.Checked = false;
            rabbitVSPenguinToolStripMenuItem.Checked = true;
            newGame();
            picPath1 = @"..\\rabbit.jpg";
            picPath2 = @"..\\penguin.jpg";
            game = "coelhos";
            this.Text = "Pegue os Coelhos";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }
        void congratulations()
        {
            sheeps.Clear();
            chickens.Clear();
            Invalidate();
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            endCounter++;
            if (MYscore >= 0)
            {
                if (endCounter == 50)
                {
                    timer3.Enabled = false;
                }
                sheep s = new sheep(picPath1);
                s.x = rnd.Next(0, 555);
                s.y = rnd.Next(66, 444);
                sheeps.Add(s);
                sheep s1 = new sheep(picPath1);
                s1.x = rnd.Next(0, 555);
                s1.y = rnd.Next(66, 444);
                sheeps.Add(s1);
                Invalidate();
                pause = true;
            }
            else
            {
                if (endCounter == 70) timer3.Enabled = false;
                chicken c = new chicken(picPath2);
                c.x = rnd.Next(0, 555);
                c.y = rnd.Next(66, 444);
                chickens.Add(c);
                chicken c1 = new chicken(picPath2);
                c1.x = rnd.Next(0, 555);
                c1.y = rnd.Next(66, 444);
                chickens.Add(c1);
                Invalidate();
                pause = true;
            }
            if (label8.ForeColor == Color.Red)
                label8.ForeColor = Color.Blue;
            else if (label8.ForeColor == Color.Blue)
                label8.ForeColor = Color.Red;

            if (label1.ForeColor == Color.Red)
                label1.ForeColor = Color.Blue;
            else label1.ForeColor = Color.Red;


            if (label2.ForeColor == Color.Red)
                label2.ForeColor = Color.Blue;
            else label2.ForeColor = Color.Red;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}