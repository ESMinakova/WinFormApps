using BallGamesClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<RandomPictureBoxBall> pictureBoxBalls;       
        int quantityOfBalls = 5;
        int numberOfInnerBalls;

        public MainForm()
        {
            InitializeComponent();
        }

        private void stopMovingButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in pictureBoxBalls)
            {
                if (ball.IsInBorders)
                {
                    numberOfInnerBalls++;                    
                }
                ball.Stop();
            }            
            MessageBox.Show("Количество пойманных шариков: " + numberOfInnerBalls);
            numberOfInnerBalls = 0;            
        }
        
        private void startMovingButton_Click(object sender, EventArgs e)
        {

            if (pictureBoxBalls != null)
            {
                ClearField();
            }
            numberOfInnerBalls = 0;
            pictureBoxBalls = new List<RandomPictureBoxBall>();
            
            for (int i = 0; i < quantityOfBalls; i++)
            {
                var pictureBoxBall = new RandomPictureBoxBall(this);
                pictureBoxBalls.Add(pictureBoxBall);
                pictureBoxBall.Start();
            }
        }

        private void ClearField()
        {
            foreach (var ball in pictureBoxBalls)
            {
                ball.Stop();
                ball.Dispose();                
            }
        }
    }
}
