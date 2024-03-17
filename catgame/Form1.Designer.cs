namespace catgame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Floor = new PictureBox();
            pictureBox2 = new PictureBox();
            txtscore = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            melody = new PictureBox();
            retry = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Floor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)melody).BeginInit();
            ((System.ComponentModel.ISupportInitialize)retry).BeginInit();
            SuspendLayout();
            // 
            // Floor
            // 
            Floor.BackColor = Color.DarkSlateGray;
            Floor.Location = new Point(-8, 502);
            Floor.Name = "Floor";
            Floor.Size = new Size(995, 62);
            Floor.TabIndex = 0;
            Floor.TabStop = false;
            Floor.Tag = "Floor";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icegif_208;
            pictureBox2.Location = new Point(339, 59);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.MaximumSize = new Size(125, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 0);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // txtscore
            // 
            txtscore.AutoSize = true;
            txtscore.Font = new Font("Malsberger Fax", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            txtscore.ForeColor = Color.MediumPurple;
            txtscore.Location = new Point(12, 37);
            txtscore.Name = "txtscore";
            txtscore.Size = new Size(140, 33);
            txtscore.TabIndex = 6;
            txtscore.Text = "Score : 0";
            // 
            // Timer
            // 
            Timer.Interval = 20;
            Timer.Tick += MainGameTimerEvent;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ezgif_5_61e5b3b372;
            pictureBox3.Location = new Point(602, 461);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._200w;
            pictureBox4.Location = new Point(455, 451);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "obstacle";
            // 
            // melody
            // 
            melody.Image = Properties.Resources.running;
            melody.Location = new Point(110, 430);
            melody.Margin = new Padding(0);
            melody.Name = "melody";
            melody.Size = new Size(66, 77);
            melody.SizeMode = PictureBoxSizeMode.Zoom;
            melody.TabIndex = 9;
            melody.TabStop = false;
            melody.Tag = "melody";
            // 
            // retry
            // 
            retry.Image = Properties.Resources.imgbin_computer_icons_symbol_symbol_5KyHM5d2K6N9HxxwV3ZT3ZR1x_t_removebg_preview;
            retry.Location = new Point(418, 212);
            retry.Name = "retry";
            retry.Size = new Size(96, 101);
            retry.SizeMode = PictureBoxSizeMode.Zoom;
            retry.TabIndex = 10;
            retry.TabStop = false;
            retry.Tag = "retry";
            retry.Click += RetryClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 522);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 11;
            label1.Text = "*use spacebar to jump*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 551);
            Controls.Add(label1);
            Controls.Add(retry);
            Controls.Add(Floor);
            Controls.Add(melody);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(txtscore);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "melody game";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)Floor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)melody).EndInit();
            ((System.ComponentModel.ISupportInitialize)retry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Floor;
        private PictureBox pictureBox2;
        private Label txtscore;
        private System.Windows.Forms.Timer Timer;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox melody;
        private PictureBox retry;
        private Label label1;
    }
}