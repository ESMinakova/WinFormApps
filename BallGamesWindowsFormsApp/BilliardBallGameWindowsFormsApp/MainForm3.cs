using BallGamesClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BilliardBallGameWindowsFormsApp
{
    public partial class MainForm3 : Form
    {
        List<PictureBoxBall> reflectingBalls;
        int quantityOfBalls = 10;
        int leftCount = 0;
        int rightCount = 0;
        int upperCount = 0;
        int downCount = 0;
        public MainForm3()
        {
            InitializeComponent();
        }
                
        private void startMovingButton_Click_1(object sender, EventArgs e)
        {
            if (reflectingBalls != null)
            {
                ClearField();
                leftCount = 0;
                rightCount = 0;
                upperCount = 0;
                downCount = 0;
                ShowCountOnForm();
            }
            reflectingBalls = new List<PictureBoxBall>();              
            for (int i = 0; i < quantityOfBalls; i++)
            {
                var reflectingBall = new BillyardPictureBoxBall(this);
                reflectingBall.OnHited += ReflectingBall_OnHited;                
                reflectingBalls.Add(reflectingBall);
                reflectingBall.Start();
            }

        }

        private void ReflectingBall_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Type)
            {
                case HitType.Left:
                    leftCounterLabel.Text = leftCount++.ToString();
                    break;
                case HitType.Right:
                    rightCounterLabel.Text = rightCount++.ToString();
                    break;
                case HitType.Up:
                    topCounterLabel.Text = upperCount++.ToString();
                    break;
                case HitType.Down:
                    downCounterLabel.Text = downCount++.ToString();
                    break;
            }
        }

        private void stopMovingButton_Click_1(object sender, EventArgs e)
        {
            foreach (var ball in reflectingBalls)
            {
                ball.Stop();
            }
        }

        private void ClearField()
        {
            foreach (var ball in reflectingBalls)
            {
                ball.Stop();
                ball.Dispose();
            }
        }

        private void ShowCountOnForm()
        {
            leftCounterLabel.Text = leftCount++.ToString();
            rightCounterLabel.Text = rightCount++.ToString();
            topCounterLabel.Text = upperCount++.ToString();
            downCounterLabel.Text = downCount++.ToString();
        }

    }
}