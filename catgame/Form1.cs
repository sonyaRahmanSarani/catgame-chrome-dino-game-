using System.Drawing;

namespace catgame
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed = 12;
        int force = 12; 
        int score = 0; 
        int obstacleSpeed = 10;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            melody.Top += jumpSpeed;
            txtscore.Text = "Score: " + score;
            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed; 
                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
         
                        score++;
                    }
                    if (melody.Bounds.IntersectsWith(x.Bounds))
                    {
                        
                        Timer.Stop();
                        retry.Enabled = true;
                        retry.Visible = true;
                      
                        melody.Image = Properties.Resources.dead;
                        txtscore.Text += "        Press R to play again";
                    }
                }
            }
            
            if (melody.Top >= 401 && !jumping)
            {
                force = 12; 
                melody.Top = Floor.Top - melody.Height; 
                jumpSpeed = 0; 
            }
            if (score >= 10)
            {
                obstacleSpeed = 13;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                GameReset();
            }
            if (jumping)
            {
                jumping = false;
            }
        }

        private void GameReset()
        {

            force = 12;
            melody.Top = Floor.Top - melody.Height; 
            jumpSpeed = 0; 
            jumping = false; 
            score = 0; 
            obstacleSpeed = 10; 
            txtscore.Text = "Score: " + score; 
            melody.Image = Properties.Resources.running; 
            retry.Enabled = false;
            retry.Visible = false;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    
                    int position = rnd.Next(600, 1000);
                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }
            Timer.Start();
        }

        private void RetryClick(object sender, EventArgs e)
        {
            GameReset();
        }
    }
}