using FruitNinjaWindowsFormsApp.Properties;
using System;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class FruitNinjaBall : GravityPictureBoxBall
    {
        public FruitNinjaBall(Form form) : base(form)
        {
            Image = Resources.orange;
            centerY = DownBorder + Radius;            
            vy = (float)(random.NextDouble() - 1) * 13 - 22;
            Radius = random.Next(20, 50);
            timer.Interval = 50;
            DetermineStartValues();
            MouseMove += FruitNinjaBall_MouseMove;
        }

        private void FruitNinjaBall_MouseMove(object sender, MouseEventArgs e)
        {
            Stop();
            Dispose();
        }

        protected override void Timer_Tick(object sender, EventArgs e)
        {
            base.Timer_Tick(sender, e);
            timePerTicks += 0.2;
        }

    }
}
