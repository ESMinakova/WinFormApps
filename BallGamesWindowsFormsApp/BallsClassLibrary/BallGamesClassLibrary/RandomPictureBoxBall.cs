using System;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class RandomPictureBoxBall: PictureBoxBall
    {
        protected static Random random = new Random();
        public RandomPictureBoxBall(Form form) : base(form)
        {
            centerX = random.Next(LeftBorder, RightBorder);
            centerY = random.Next(UpperBorder, DownBorder);
            vx = (float)(random.NextDouble() - 0.5) * 30;
            vy = (float)(random.NextDouble() - 0.5) * 30;
            Radius = random.Next(15, 50);
            DetermineStartValues();            
        }
        public void MoveSlowly()
        {
            vx = (float)(random.NextDouble() - 0.5) * 5;
            vx = (float)(random.NextDouble() - 0.5) * 5;
        }
    }
}
