
namespace WIN_ZOMBİE_Shooter_Game
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
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.sta = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.healtxt = new System.Windows.Forms.Label();
            this.killtxt = new System.Windows.Forms.Label();
            this.ammotxt = new System.Windows.Forms.Label();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar2.ForeColor = System.Drawing.Color.Gold;
            this.progressBar2.Location = new System.Drawing.Point(883, 22);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(226, 23);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 13;
            this.progressBar2.Value = 100;
            // 
            // sta
            // 
            this.sta.AutoSize = true;
            this.sta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sta.Location = new System.Drawing.Point(777, 27);
            this.sta.Name = "sta";
            this.sta.Size = new System.Drawing.Size(84, 18);
            this.sta.TabIndex = 12;
            this.sta.Text = "STAMİNA:";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(472, 22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Value = 100;
            // 
            // healtxt
            // 
            this.healtxt.AutoSize = true;
            this.healtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.healtxt.Location = new System.Drawing.Point(383, 27);
            this.healtxt.Name = "healtxt";
            this.healtxt.Size = new System.Drawing.Size(77, 18);
            this.healtxt.TabIndex = 10;
            this.healtxt.Text = "HEALTH:";
            // 
            // killtxt
            // 
            this.killtxt.AutoSize = true;
            this.killtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.killtxt.Location = new System.Drawing.Point(205, 27);
            this.killtxt.Name = "killtxt";
            this.killtxt.Size = new System.Drawing.Size(55, 18);
            this.killtxt.TabIndex = 9;
            this.killtxt.Text = "KILL:0";
            // 
            // ammotxt
            // 
            this.ammotxt.AutoSize = true;
            this.ammotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ammotxt.Location = new System.Drawing.Point(19, 27);
            this.ammotxt.Name = "ammotxt";
            this.ammotxt.Size = new System.Drawing.Size(73, 18);
            this.ammotxt.TabIndex = 8;
            this.ammotxt.Text = "AMMO:0";
            // 
            // Gametimer
            // 
            this.Gametimer.Enabled = true;
            this.Gametimer.Interval = 20;
            this.Gametimer.Tick += new System.EventHandler(this.Gametimer_Tick_1);
            // 
            // player
            // 
            this.player.Image = global::WIN_ZOMBİE_Shooter_Game.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(527, 375);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 14;
            this.player.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(292, 22);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1222, 853);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.sta);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.healtxt);
            this.Controls.Add(this.killtxt);
            this.Controls.Add(this.ammotxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label sta;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label healtxt;
        private System.Windows.Forms.Label killtxt;
        private System.Windows.Forms.Label ammotxt;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer Gametimer;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

