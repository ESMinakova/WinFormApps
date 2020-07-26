using SaluteBallGameWindowsFormsApp.Properties;
using System;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class SaluteBall: GravityPictureBoxBall
    {
        
        public SaluteBall(Form form, int x, int y) : base(form)
        {
            Image = Resources.goldenball;
            centerX = x;
            centerY = y;
            vy = (float)(random.NextDouble() - 1) * 15 - 15;
            Radius = 10;
            DetermineStartValues();
        }

        protected override void Timer_Tick(object sender, EventArgs e)
        {
            base.Timer_Tick(sender, e);            
            timePerTicks += 0.5;            
        }
        
    }
}
