using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WIN_ZOMBİE_Shooter_Game
{
    class Bullet
    {
        public string direction;
        public int bulletleft;
        public int bullettop;
        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTime = new Timer();
        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.White;

            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletleft;
            bullet.Top = bullettop;
            bullet.BringToFront();
            form.Controls.Add(bullet);
            bulletTime.Interval = speed;
            bulletTime.Tick += new EventHandler(BulletTimeEvent);
            bulletTime.Start();
        }


        private void BulletTimeEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                bullet.Left -= speed;

            }
            if (direction == "right")
            {
                bullet.Left += speed;
            }
            if (direction == "up")
            {
                bullet.Top -= speed;
            }
            if (direction == "down")
            {
                bullet.Top += speed;

            }
            if (bullet.Left < 10 || bullet.Left > 900 || bullet.Top < 30 || bullet.Top > 700)
            {
                bulletTime.Stop();
                bulletTime.Dispose();
                bullet.Dispose();
                bullet = null;
                bulletTime = null;
            }
        }

    }
}
