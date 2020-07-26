using AngryBirdsBallGameWindowsFormsApp.Properties;
using System;
using System.Windows.Forms;

namespace AngryBirdsBallGameWindowsFormsApp
{
    public partial class angryBirdsMainForm : Form
    {
        PiggyBall piggyBall;
        BirdyBall birdyBall;       
        
        public angryBirdsMainForm()
        {
            InitializeComponent();
        }

        private void angryBirdsMainForm_Load(object sender, EventArgs e)
        {
            ShowNewBirdy();
            ShowNewPiggy();

        }        

        private void angryBirdsMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            timer.Start();
            birdyBall.DetermineVelocity(e.X, e.Y);
            birdyBall.Start();            
        }


        private void nextTryingButton_Click(object sender, EventArgs e)
        {
            ShowNewBirdy();       

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            if (birdyBall.IsPictureBoxesCrushed(piggyBall))
            {
                piggyBall.Image = Resources.crushedpig;
                birdyBall.Clear();
                crushingTimer.Start();                
                
            }
            else if (birdyBall.Left > 1 && birdyBall.IsBallAlreadyStopped())
            {
                birdyBall.Clear();
                ShowNewBirdy();                
            }
        }

        private void ShowNewBirdy()
        {
            if (birdyBall != null)
            {
                birdyBall.Clear();
            }
            birdyBall = new BirdyBall(this);
            birdyBall.Show();
        }
        private void ShowNewPiggy()
        {
            if (piggyBall != null)
            {
                piggyBall.Clear();
            }
            piggyBall = new PiggyBall(this);
            piggyBall.Show();
            crushingTimer.Stop();
        }

        private void nextPigButton_Click(object sender, EventArgs e)
        {
            birdyBall.Clear();
            ShowNewBirdy();
            piggyBall.Clear();
            ShowNewPiggy();
        }

        private void crushingTimer_Tick(object sender, EventArgs e)
        {            
            ShowNewPiggy();
            ShowNewBirdy();
        }
    }
}
