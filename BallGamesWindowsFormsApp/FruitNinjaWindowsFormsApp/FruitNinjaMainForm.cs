using BallGamesClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public partial class fruitNinjaForm : Form
    {
        List<FruitNinjaBall> fruitNinjaBalls = new List<FruitNinjaBall>();        
        int numberOfCatchedBalls = 0;
        static Random random = new Random();
        public fruitNinjaForm()
        {
            InitializeComponent();
            GenerateRandomTimerInterval();
        }


        private void MainTimer_Tick(object sender, System.EventArgs e)
        {
            var countBall = random.Next(2, 7);
            for (int i = 0; i < countBall; i++)
            {
                var fruitNinjaBall = new FruitNinjaBall(this);
                fruitNinjaBall.MouseMove += FruitNinjaBall_MouseMove;
                fruitNinjaBalls.Add(fruitNinjaBall);
                fruitNinjaBall.Start();
            }
            GenerateRandomTimerInterval();
        }

        private void FruitNinjaBall_MouseMove(object sender, MouseEventArgs e)
        {
            numberOfCatchedBalls++;            
            ViewCatchedBalls();            
        }

        private void GenerateRandomTimerInterval()
        {
            var randomInterval = random.Next(1000, 4000);
            mainTimer.Interval = randomInterval;
        }       


        private void ViewCatchedBalls()
        {
            numberOfCatchedBallsLabel.Text = numberOfCatchedBalls.ToString();
            
        }

        private void startMovingButton_Click(object sender, EventArgs e)
        {
            mainTimer.Enabled = true;
            numberOfCatchedBalls = 0;
            ViewCatchedBalls();
        }
    

        private void stopMovingButton_Click(object sender, EventArgs e)
        {
            mainTimer.Enabled = false;            
        }
    }
}
