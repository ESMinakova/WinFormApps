﻿using BallGamesClassLibrary.Properties;
using System;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class BillyardPictureBoxBall: RandomPictureBoxBall
    {

        public event EventHandler<HitEventArgs> OnHited;
        public BillyardPictureBoxBall(Form form) : base(form)
        {
            Image = Resources.billyardball;
            
        }
        protected override void Go()
        {
            base.Go();
            {
                if (centerX < LeftBorder)
                {
                    vx = -vx;
                    OnHited?.Invoke(this, new HitEventArgs(HitType.Left));   // То же самое, что условие if (OnHited != null)                

                }
                if (centerX > RightBorder)
                {
                    vx = -vx;
                    OnHited?.Invoke(this, new HitEventArgs(HitType.Right));
                }
                if (centerY < UpperBorder)
                {
                    vy = -vy;
                    OnHited?.Invoke(this, new HitEventArgs(HitType.Up));
                }
                if (centerY > DownBorder)
                {
                    vy = -vy;
                    OnHited?.Invoke(this, new HitEventArgs(HitType.Down));
                }
            }
        }
        }
}
