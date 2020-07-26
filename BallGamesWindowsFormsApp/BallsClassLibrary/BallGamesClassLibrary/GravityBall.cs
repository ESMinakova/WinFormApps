using System;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class GravityBall: RandomBall
    {
        protected const double G = 9.8;
        protected double angle;
        protected double hypotenuze;
        protected double timePerTicks = 1;
        public GravityBall(Form form) : base(form)
        {
            hypotenuze = Math.Sqrt(vx * vx + vy * vy); // вычисление гипотенузы прямоугольного треугольника, необходимого для дальнейших расчетов. Он же вектор скорости
            angle = Math.Acos(vx / hypotenuze); // вычисление угла движения шарика, необходимого для дальнейших расчетов
        }
        protected override void Go()
        {
            base.Go();
            centerX = (float)(centerX + (hypotenuze * Math.Cos(angle) * timePerTicks));            
            centerY = (float)(centerY - (hypotenuze * Math.Sin(angle) * timePerTicks - ((G * timePerTicks * timePerTicks) / 2)));
        }
    }
}
