using BallGamesClassLibrary;
using System.Windows.Forms;

namespace SnakeBallGameWindowsFormsApp
{
    public class BaseSnake : PictureBoxBall
    {
        
        public BaseSnake(Form form) : base(form)
        {
            timer.Interval = 100;
            Radius = 20;
            vx = 2 * Radius;
            vy = 2 * Radius;
            centerX = (random.Next(0, RightBorder) / (2 * Radius)) * (2 * Radius) + Radius;
            centerY = (random.Next(0, DownBorder) / (2 * Radius)) * (2 * Radius) + Radius;
            DetermineStartValues();
        }   
        public int Diametr
        {
            get
            {
                return Radius * 2;
            }
        }

        

        public void MoveX()
        {
            centerX += vx;
            if (centerX > RightBorder)
            {
                centerX = LeftBorder;
            }
            if (centerX < LeftBorder)
            {
                centerX = RightBorder;
            }
            Draw();
        }
        public void MoveY()
        {
            centerY += vy;
            if (centerY > DownBorder)
            {
                centerY = UpperBorder;
            }
            if (centerY < UpperBorder)
            {
                centerY = DownBorder;
            }
            Draw();
        }

        public void SetCoordinates(BaseSnake snake)
        {
            centerX = snake.centerX;
            centerY = snake.centerY;
        }
       
    }
}
