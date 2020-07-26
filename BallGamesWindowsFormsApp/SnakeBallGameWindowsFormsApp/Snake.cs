using BallGamesClassLibrary;
using SnakeBallGameWindowsFormsApp.Properties;
using System;
using System.Windows.Forms;

namespace SnakeBallGameWindowsFormsApp
{
    public class Snake : BaseSnake
    {
        public Snake(Form form) : base(form)
        {
            Image = Resources.snake;
        }
    }
}
