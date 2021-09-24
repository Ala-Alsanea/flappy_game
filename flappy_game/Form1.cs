using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_game
{
    public partial class Form1 : Form
    {

        int pipSpeed = 10;
        int gravity = 10;
        int score = 0;
        Extra extra = new Extra();
        


        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            lbl_test.Text = Convert.ToString(pipSpeed );
            lbl_score.Text = "Score: " + score.ToString();

            extra.pipMoves(pipUp, pipDown, pipSpeed);
            score = extra.pipReset(pipUp, pipDown, score);
            pipSpeed = extra.increaseSpeed(pipSpeed, score);
          
            if(bird.Bounds.IntersectsWith(pipUp.Bounds)||
                bird.Bounds.IntersectsWith(pipDown.Bounds)||
                bird.Bounds.IntersectsWith(ground.Bounds)||
                bird.Top < -10)
            {
                
                gameOver();
            }


        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            lbl_score.ForeColor = Color.Red;
            if (e.KeyCode == Keys.Space)
            {

                gravity = extra.changeToNagitive(gravity);
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            lbl_score.ForeColor = Color.Gray;
            if (e.KeyCode == Keys.Space)
            {
                gravity = extra.changeToPositive(gravity);
            }
        }

        void gameOver()
        {
            gameTimer.Stop();
            pipDown.Hide();
            pipUp.Hide();
            bird.Hide();
            gameTimer.Tag = "stoped";
            lbl_gameOver.Show();
            //btn_start.Show();
            

        }

        private void click_to_start(object sender, EventArgs e)
        {


            gameTimer.Start();
            gameTimer.Tag = "work";

          //    pipDown.Left = 191;
            pipDown.Show();

            //pipUp.Left = 177;
            pipUp.Show();

           // bird.Left = 34;
            bird.Show();

            ground.Show();

            lbl_score.Show();
            lbl_gameOver.Hide();


           // btn_start.Hide();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // gameTimer.Stop();
        }
    }
}
