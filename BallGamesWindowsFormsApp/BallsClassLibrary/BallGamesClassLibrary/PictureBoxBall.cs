using BallGamesClassLibrary.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class PictureBoxBall : PictureBox
    {
        private Form form;
        protected Timer timer;
        public float vx = 1;
        public float vy = 1;
        protected float centerX = 50;
        protected float centerY = 50;
        public int Radius { get; set; }

        protected Random random = new Random();
        
        public PictureBoxBall(Form form)
        {
            this.form = form;
            DetermineStartValues();
            

            form.Controls.Add(this);
            Image = Resources.ball1;
            SizeMode = PictureBoxSizeMode.StretchImage;

            MouseClick += PictureBoxBall_MouseClick;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;            
        }

        

        private void PictureBoxBall_MouseClick(object sender, MouseEventArgs e)
        {
            Stop();
            Dispose();
        }

        protected void DetermineStartValues()
        {
            Width = 2 * Radius;
            Height = 2 * Radius;
            Top = (int)centerY - Radius;
            Left = (int)centerX - Radius;
        }

        public bool IsInBorders
        {
            get
            {
                if ((centerX > Radius && centerX < (form.ClientSize.Width - Radius)) && (centerY > Radius && centerY < (form.ClientSize.Height - Radius)))
                {
                    return true;
                }
                return false;
            }
        }

        public int RightBorder
        {
            get
            {
                return form.ClientSize.Width - Radius;
            }
        }
        public int LeftBorder
        {
            get
            {
                return Radius;
            }
        }
        public int UpperBorder
        {
            get
            {
                return Radius;
            }
        }
        public int DownBorder
        {
            get
            {
                return form.ClientSize.Height - Radius;
            }
        }


        public void Draw()
        {
            Top = (int)centerY - Radius;
            Left = (int)centerX - Radius;
        }


        public bool IsClickOnBall(int xClick, int yClick)
        {
            if ((xClick - centerX) * (xClick - centerX) + (yClick - centerY) * (yClick - centerY) <= (Radius) * (Radius))
            {
                return true;
            }
            return false;
        }
               

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
        
        public void Clear()
        {
            timer.Dispose();
            Dispose();            
        }


        public bool IsBallAlreadyStopped()
        {
            if (timer.Enabled == true)
            {
                return false;
            }
            return true;
        }       

        public bool IsPictureBoxesCrushed (PictureBoxBall other)
        {
            var deltaX = this.centerX - other.centerX;
            var deltaY = this.centerY - other.centerY;
            var length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return length < this.Radius + other.Radius;           
        }

        protected virtual void Move()
        {
            Go();
            Draw();
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;

            if (Left >= form.ClientSize.Width * 2)
            {
                Stop();
            }
        }
        protected virtual void Timer_Tick(object sender, System.EventArgs e)
        {
            Move();
        }        
    }
}
