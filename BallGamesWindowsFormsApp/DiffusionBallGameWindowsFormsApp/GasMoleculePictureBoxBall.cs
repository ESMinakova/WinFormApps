using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class GasMoleculePictureBoxBall : BillyardPictureBoxBall
    {
        public GasMoleculePictureBoxBall(Form form) : base(form)
        {
            Radius = 10;
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);
            DetermineStartValues();
        }
        public void ChangeBallsMoving()
        {
            timer.Enabled = !timer.Enabled;
        }
    }
}
