using AngryBirdsBallGameWindowsFormsApp.Properties;
using BallGamesClassLibrary;
using System;
using System.Windows.Forms;

namespace AngryBirdsBallGameWindowsFormsApp
{
    public class BirdyBall : RandomPictureBoxBall
    {
            
        private float g = 0.4f;
        private const float elastic = 0.70f;

        public BirdyBall(Form form) : base(form)
        {
            Image = Resources.parrot;
            Radius = 30;
            centerX = Radius;
            centerY = DownBorder;
            timer.Interval = 10;
            DetermineStartValues();
        }        

        public void DetermineVelocity(int x, int y)
        {
            if (IsBallAlreadyStopped())
            {
                vx = (x - centerX) / 15;
                vy = (y - centerY) / 15;
            }          
                      
        }
        
        public void HitDownBorder()
        {
            if (centerY > DownBorder)
            {
                vy = -vy * elastic;
                vx *= elastic;
                if ((vx < 0.1 && vy < 0.1f) || centerX > RightBorder)
                {
                    Stop();
                }
            }       
        }  

        protected override void Go()
        {
            base.Go();
            HitDownBorder();
            vy += g;                
        }

    }
}
