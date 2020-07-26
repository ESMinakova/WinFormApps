using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeBallGameWindowsFormsApp
{
    public partial class SnakeMainForm : Form
    {
        List<BaseSnake> snake;
        BaseSnake Head => snake[0];
        Food food;
        Timer timer;
        Direction direction = Direction.Right;
        int countSnakeParts = 0;
        int timerStep = 2;
        BaseSnake baseSnakeBall;
        int scoreCounter = 0;
        int newFormWidthInBalls = 20;
        int newFormHeighInBalls = 15


        public SnakeMainForm()
        {
            InitializeComponent();
            ShowScore();
            baseSnakeBall = new BaseSnake(this);            
            baseSnakeBall.Clear();
            Size = new Size(baseSnakeBall.Diametr * newFormWidthInBalls, baseSnakeBall.Diametr * newFormHeighInBalls);
            timer = new Timer();
            timer.Interval = 130;
            timer.Tick += Timer_Tick;
        }


        private void SnakeMainForm_Load(object sender, EventArgs e)
        {

            snake = new List<BaseSnake>();
            var head = new Snake(this);            
            head.MoveX();
            head.MoveY();
            head.Draw();
            snake.Add(head);
            food = new Food(this);
            food.Draw();
            timer.Start();

        }

        private void SnakeMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && direction != Direction.Right)
            {
                direction = Direction.Left;
            }
            if (e.KeyCode == Keys.Right && direction != Direction.Left)
            {
                direction = Direction.Right;
            }
            if (e.KeyCode == Keys.Up && direction != Direction.Down)
            {
                direction = Direction.Up;
            }
            if (e.KeyCode == Keys.Down && direction != Direction.Up)
            {
                direction = Direction.Down;
            }
        }

        public void MoveSnake()
        {
            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i].SetCoordinates(snake[i - 1]);
                snake[i].Draw();
            }
            MoveHead();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Head.IsPictureBoxesCrushed(food))
            {
                scoreCounter++;
                ShowScore();
                var snakeBall = new Snake(this);
                snake.Add(snakeBall);
                CreateNewFood();                
                timer.Interval = Math.Max(timerStep, timer.Interval - timerStep);
                
            }
            for (int i = 2; i < snake.Count; i++)
            {
                if (Head.IsPictureBoxesCrushed(snake[i]))
                {
                    timer.Stop();
                    MessageBox.Show("Игра закончена");
                    Application.Restart();
                }
            }
            MoveSnake();
        }

        private void CreateNewFood()
        {
            do
            {
                countSnakeParts = 0;
                food.Clear();
                food = new Food(this);
                for (int i = 0; i < snake.Count; i++)
                {
                    if (!food.IsPictureBoxesCrushed(snake[i]))
                    {
                        countSnakeParts++;
                    }
                }
            }
            while (countSnakeParts != snake.Count);
            food.Show();
        }

        private void MoveHead()
        {
            switch (direction)
            {
                case Direction.Up:
                    Head.vy = -Math.Abs(Head.vy);
                    Head.MoveY();
                    break;
                case Direction.Down:
                    Head.vy = Math.Abs(Head.vy);
                    Head.MoveY();
                    break;
                case Direction.Left:
                    Head.vx = -Math.Abs(Head.vx);
                    Head.MoveX();
                    break;
                case Direction.Right:
                    Head.vx = Math.Abs(Head.vx);
                    Head.MoveX();
                    break;
            }
        }

        private void ShowScore()
        {
            scoreLabel.Text = "Количество очков: " + scoreCounter.ToString();
        }
    }
}