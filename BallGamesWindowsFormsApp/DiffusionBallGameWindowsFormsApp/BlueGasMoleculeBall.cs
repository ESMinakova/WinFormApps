using DiffusionBallGameWindowsFormsApp.Properties;
using System.Windows.Forms;

namespace BallGamesClassLibrary
{
    public class BlueGasMoleculeBall : GasMoleculePictureBoxBall
    {
        public BlueGasMoleculeBall(Form form) : base(form)
        {
            Image = Resources.purpleball;
            centerX = random.Next(form.ClientSize.Width / 2 + Radius, form.ClientSize.Width - Radius);
            DetermineStartValues();           
            
        }
        public bool IsBlueMoleculeBallOnOppositeSide(Form form)
        {
            if (centerX <= form.ClientSize.Width / 2 - Radius)
            {
                return true;
            }
            return false;
        }
    }
}
