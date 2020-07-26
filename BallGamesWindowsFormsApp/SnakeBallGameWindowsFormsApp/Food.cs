using BallGamesClassLibrary;
using SnakeBallGameWindowsFormsApp.Properties;
using System.Windows.Forms;

namespace SnakeBallGameWindowsFormsApp
{
    public class Food : BaseSnake
    {
        public Food(Form form) : base(form)
        {
            Image = Resources.doughnut;
        }
    }
}

