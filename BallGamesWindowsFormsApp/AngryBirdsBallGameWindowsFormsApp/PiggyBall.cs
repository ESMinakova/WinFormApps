using AngryBirdsBallGameWindowsFormsApp.Properties;
using BallGamesClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngryBirdsBallGameWindowsFormsApp
{
    public class PiggyBall : RandomPictureBoxBall
    {
        
        public PiggyBall(Form form) : base(form)
        {
            Image = Resources.pig_transparent;
            centerX = random.Next(RightBorder / 4, RightBorder);
            Radius = 40;
            DetermineStartValues();
        }       
        
    }
}
