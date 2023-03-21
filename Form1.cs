using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIN_ZOMBİE_Shooter_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Restart();
        }
        bool goup, godown, goleft, goright, gameover;
        string face = "up";
        int healtybar = 100;
        int speed = 10;
        int zomspeed = 3;
        int ammo = 10;
        int kill;
        int stamina=100;
        
        Random rnd = new Random();
        int sayac;
      

        List<PictureBox> zombielist = new List<PictureBox>();

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goup = true;
                face = "up";
                player.Image = Properties.Resources.up;

            }
            if (e.KeyCode == Keys.A)
            {
                goleft = true;
                face = "left";
                player.Image = Properties.Resources.left;

            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
                face = "right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = true;
                face = "down";
                player.Image = Properties.Resources.down;
            }
            if (e.KeyCode == Keys.Escape)
            {
                zomspeed--;
            }
            if (e.KeyCode == Keys.D1)
            {
                zomspeed++;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goup = false;

            }
            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.J && ammo > 0 && gameover == false)
            {
                ammo--;
                Bulletshoot(face);
                if (ammo < 1)
                {
                    DropAmmo();

                }





            }
            if (e.KeyCode == Keys.Enter)
            {
                Restart();
            }

        }
        private void Bulletshoot(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletleft = player.Left + (player.Width / 2);
            shootBullet.bullettop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);

        }



        private void MakeZombie()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = rnd.Next(0, 900);
            zombie.Top = rnd.Next(0, 750);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombielist.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();

        }

       

        private void Gametimer_Tick_1(object sender, EventArgs e)

        {
           
        
            if (healtybar > 1)
            {
                progressBar1.Value = healtybar;
            }
            else
            {
                gameover = true;
                player.Image = Properties.Resources.dead;
                Gametimer.Stop();
            }
            if (stamina>1)
            {
                progressBar2.Value = stamina;
            }
            if (stamina<50)
            {
                speed = 8;
            }
            else
            {
                speed = 10;
            }
           
            ammotxt.Text = "AMMO: " + ammo;
            killtxt.Text = "KİLL: " + kill;

            if (goleft == true && player.Left > 0)
            {
                player.Left -= speed;
                if (stamina>1)
                {
                    stamina--;
                }
                
            }
            if (goright == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
                if (stamina > 1)
                {
                    stamina--;
                }
            }
            if (goup == true && player.Top > 42)
            {
                player.Top -= speed;
                if (stamina > 1)
                {
                    stamina--;
                }
            }
            if (godown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
                if (stamina > 1)
                {
                    stamina--;
                }
            }
            if (stamina<99)
            {

                stamina++;
            }
            if (kill == 20)
            {
                kill++;
                DropHealt();
                

            }
            if (kill == 50)
            {
                kill++;
                DropHealt();


            }
            foreach (Control k in this.Controls)
            {
                if (k is PictureBox && (string)k.Tag == "healt")
                {
                  
                    
                        if (player.Bounds.IntersectsWith(k.Bounds))
                        {

                            progressBar1.Maximum = 150;
                            healtybar = 100;
                            this.Controls.Remove(k);
                            ((PictureBox)k).Dispose();
                            
                        }
                     
                        
                    
                    
                }
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {

                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;

                    }
                }
                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        healtybar--;
                    }


                    if (x.Left > player.Left)
                    {
                        x.Left -= zomspeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zomspeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zomspeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zomspeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            kill++;
                            this.Controls.Remove(x);
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            ((PictureBox)x).Dispose();
                            zombielist.Remove((PictureBox)x);
                            MakeZombie();
                            if (healtybar < 100)
                            {
                                healtybar++;
                            }
                            

                        }
                    }
                }
            }

        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize; // Mod  unu yazmayı unutma size 
            ammo.Left = rnd.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = rnd.Next(40, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();


        }
        private void DropHealt()
        {
            PictureBox healt = new PictureBox();
            healt.Image = Properties.Resources.healt;
            healt.SizeMode = PictureBoxSizeMode.AutoSize;
            healt.Left = rnd.Next(10, this.ClientSize.Width - healt.Width);
            healt.Top = rnd.Next(40, this.ClientSize.Height - healt.Height);
            healt.Tag = "healt";
            this.Controls.Add(healt);
            healt.BringToFront();
            player.BringToFront();
        }
        private void Restart()
        {
            player.Image = Properties.Resources.up;
            foreach (PictureBox i in zombielist)
            {
                this.Controls.Remove(i);
            }
            zombielist.Clear();
            for (int i = 0; i < 3; i++)
            {
                MakeZombie();
            }
            goup = false;
            godown = false;
            goleft = false;
            goright = false;
            gameover = false;
            kill = 0;
            healtybar = 100;
            ammo = 10;
            Gametimer.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\User\\Desktop\\Sesler\\zombie.mp3";
            Gametimer.Stop();
            foreach (PictureBox x in zombielist)
            {
                this.Controls.Remove(x);
            }
            zombielist.Clear();
        }
    }
}
