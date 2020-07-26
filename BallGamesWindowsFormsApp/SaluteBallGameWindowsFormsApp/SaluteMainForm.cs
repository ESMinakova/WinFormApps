using BallGamesClassLibrary;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaluteBallGameWindowsFormsApp
{
    public partial class saluteMainForm : Form
    {
        List<RandomPictureBoxBall> saluteBalls;
        int quantityOfBalls = 10;
        public saluteMainForm()
        {
            InitializeComponent();
        }        

        private void saluteMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            saluteBalls = new List<RandomPictureBoxBall>();
            for (int i = 0; i < quantityOfBalls; i++)
            {
                var saluteBall = new SaluteBall(this, e.X, e.Y);                
                saluteBalls.Add(saluteBall);
                saluteBall.Start();
            }
        }
    }
}
