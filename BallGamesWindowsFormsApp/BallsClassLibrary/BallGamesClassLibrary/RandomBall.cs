using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class RandomBall : RandomPointBall
    {
        public RandomBall(Form form) : base(form)
        {
            vx = (float)(random.NextDouble() - 0.5) * 10;
            vy = (float)(random.NextDouble() - 0.5) * 10;            
            radius = random.Next(15, 50);
            color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        public void MoveSlowly()
        {
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);
        }
    }
}
