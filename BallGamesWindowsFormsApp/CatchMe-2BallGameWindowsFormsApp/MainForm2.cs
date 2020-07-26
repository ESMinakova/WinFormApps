using BallGamesClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CatchMe_2BallGameWindowsFormsApp
{
    public partial class MainForm2 : Form
    {
        List<RandomPictureBoxBall> balls;
        int quantityOfBalls = 10;
        int numberOfInnerBalls;
        RandomPictureBoxBall randomBall;
        public MainForm2()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
                      
        }       

        private void startMovingButton_Click_1(object sender, EventArgs e)
        {
            if (balls != null)
            {
                ClearField();
            }
            numberOfInnerBalls = 0;
            ShowCountOnForm();
            balls = new List<RandomPictureBoxBall>();

            for (int i = 0; i < quantityOfBalls; i++)
            {
                randomBall = new RandomPictureBoxBall(this);
                
                balls.Add(randomBall);
                randomBall.MouseClick += RandomBall_MouseClick1;
                randomBall.MoveSlowly();
                randomBall.Start();
            }
        }

        private void RandomBall_MouseClick1(object sender, MouseEventArgs e)
        {
            numberOfInnerBalls++;
            ShowCountOnForm();
        }

        private void ShowCountOnForm()
        {
            numberOfCatchedBallsLabel.Text = numberOfInnerBalls.ToString();
        }      


        private void ClearField()
        {
            foreach (var ball in balls)
            {
                ball.Stop();
                ball.Dispose();
            }
        }

        private void clearFieldButton_Click_1(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
