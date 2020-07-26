using DiffusionBallGameWindowsFormsApp.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class RedGasMoleculeBall : GasMoleculePictureBoxBall
    {
        public RedGasMoleculeBall(Form form) : base(form)
        {
            centerX = random.Next(Radius, form.ClientSize.Width / 2 - Radius);
            Image = Resources.redball;
            DetermineStartValues();
        }

        public bool IsRedMoleculeBallOnOppositeSide(Form form)
        {
            if (centerX >= form.ClientSize.Width / 2 + Radius)
            {
                return true;
            }
            return false;
        }
    }
}
