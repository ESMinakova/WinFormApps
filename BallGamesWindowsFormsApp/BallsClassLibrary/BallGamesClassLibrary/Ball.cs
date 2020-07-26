using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class Ball
    {
        private Form form;    

        protected Timer timer;
        private Graphics graphics;
        protected float vx = 1;
        protected float vy = 1;
        protected float centerX = 50;
        protected float centerY = 50;
        protected int radius = 50;
        protected Color color = Color.FromArgb(0, 0, 0);

        public Ball(Form form)
        {
            this.form = form;
            graphics = form.CreateGraphics();
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }
      
        public bool IsInBorders
        {
            get
            {
                if ((centerX > radius && centerX < (form.ClientSize.Width - radius)) && (centerY > radius && centerY < (form.ClientSize.Height - radius)))
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
                return form.ClientSize.Width - radius;
            }
        }
        public int LeftBorder
        {
            get
            {
                return radius;
            }
        }
        public int UpperBorder
        {
            get
            {
                return radius;
            }
        }
        public int DownBorder
        {
            get
            {
                return form.ClientSize.Height - radius;
            }
        }


        public void Show()
        {
            Draw(color);
        }        
               

        public bool IsClickOnBall(int xClick, int yClick)
        {
            if ((xClick - centerX) * (xClick - centerX) + (yClick - centerY) * (yClick - centerY) <= (radius) * (radius))
            {
                return true;
            }
            return false;
        }

        public void Clear()

        {
            Color color = form.BackColor;
            Draw(color);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        
        public bool IsBallAlreadyStopped()
        {
            if (timer.Enabled == true)
            {
                return false;
            }
            return true;          
        }

        
        
        protected virtual void Move()
        {
            Clear();
            Go();
            Show();
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;

            if (centerY >= form.ClientSize.Width * 2)
            {
                Stop();
            }
        }
        protected virtual void Timer_Tick(object sender, System.EventArgs e)
        {
            Move();
        }

        private void Draw(Color color)
        {
            var brush = new SolidBrush(color);
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
