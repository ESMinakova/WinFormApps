using System;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class RandomPointBall : Ball
    {
        protected static Random random = new Random();
        public RandomPointBall(Form form) : base(form)
        {
            centerX = random.Next(LeftBorder, RightBorder);
            centerY = random.Next(UpperBorder, DownBorder);
        }
    }
}
