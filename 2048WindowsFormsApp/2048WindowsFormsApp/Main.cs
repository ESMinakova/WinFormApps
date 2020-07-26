using _2048ClassLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class Main : Form
    {
        private Label[,] labelsMap;
        private int mapSize;
        //номер ячейки = i * mapSize + j
        private static Random random = new Random();       
        private int bestScore;
        Game game;
        User user;        
        
        public Main()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user = new User();
            
            var chooseMapSizeForm = new ChooseMapSizeForm();
            if (chooseMapSizeForm.ShowDialog(this) == DialogResult.OK)
            {
                mapSize = ChooseMapSizeForm.buttonResult;
                this.ClientSize = ChooseMapSizeForm.newClientSize;
            }
            else
            {
                Application.Exit();
            }
            
            var userNameForm = new UserNameForm();
            if (userNameForm.ShowDialog(this) == DialogResult.OK)
            {
                user = new User(userNameForm.userNameTextBox.Text);
            }
            else
            {
                Application.Exit();
            }

            game = new Game(user);
            InitGameMap();
            GenerateNumber();
            ShowScore();
            var isExist = FileProvider.TryGet(Game.pathToDataFileWithBestScore, out var scoreData);
            if (isExist)
            {
                bestScore = int.Parse(scoreData);
                ShowBestScore();
            }
            else
            {
                bestScore = user.Score;
            }
            PaintItBlack();
        }
        
        private void ShowScore()
        {
            currentScoreLabel.Text = user.Score.ToString();            
        }
        private void ShowBestScore()
        {
            bestScoreLabel.Text = bestScore.ToString();
        }
        private void InitGameMap()
        {
            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private void GenerateNumber()
        {
            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    var randomNumberDetermineTwoOrFour = random.Next(1, 5);
                    {
                        if (randomNumberDetermineTwoOrFour <= 3)
                        {
                            labelsMap[indexRow, indexColumn].Text = "2";
                        }
                        else
                        {
                            labelsMap[indexRow, indexColumn].Text = "4";
                        }
                        break;
                    }
                }
            }            
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();            
            label.BackColor = Color.LightGray;
            label.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.ForeColor = SystemColors.ControlText;            
            label.Size = new Size(70, 70);      
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 20 + indexColumn * 76;
            int y = 80 + indexRow * 76;
            label.Location = new Point(x, y);
            return label;
        }
        private bool IsEndOfGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    LetsPushRight();
                    break;
                case Keys.Left:
                    LetsPushLeft();
                    break;
                case Keys.Up:
                    LetsPushUp();
                    break;
                case Keys.Down:
                    LetsPushDown();
                    break;
            }
            if (!IsEndOfGame())
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    GenerateNumber();
                    ShowScore();
                    ShowBestScore();
                    PaintItBlack();
                }                
            }
            else
            {
                MessageBox.Show(user.Name + ", игра закончена");
                Game.BestScoreSaveToFile(bestScore);
                game.SaveUserResult(user.Score);
            }
        }

        public void PaintItBlack()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    DetermineLabelBackColor(labelsMap[i, j], labelsMap[i, j].Text);
                }
            }
        }


        private static Color[] colors = new Color[13]
        {
            Color.White,
            Color.SeaShell,
            Color.PeachPuff,
            Color.LightSalmon,
            Color.Coral,
            Color.OrangeRed,
            Color.Cornsilk,
            Color.LemonChiffon,
            Color.Wheat,
            Color.Khaki,
            Color.Gold,
            Color.Orange,
            Color.Chocolate
        };
    
        public static void DetermineLabelBackColor(Label label, string labelText)
        {
            if (label.Text != string.Empty)
            {
                double pow = Math.Log(int.Parse(label.Text), 2);
                label.BackColor = colors[(int)pow - 1];
            }
            else
            {
                label.BackColor = Color.LightGray;
            }
        }

        private void выходИзИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void запуститьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Используйте стрелки вверх, вниз, вправо и влево, чтобы перемещать квадраты с цифрами. " +
                "Когда два одинаковых квадрата должны встать рядом, вместо этого они сливаются в один новый квадрат, " +
                "значение которого равно сумме предыдущих. Ваша задача набрать 2048");
        }

        private void показатьРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userResultsForm = new UserResultsForm(game.GetUserResultFromFile());
            userResultsForm.Show();
        }
        private void LetsPushRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, k].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, k].Text = string.Empty;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    user.CalculateScore(number);
                                    if (user.Score > bestScore)
                                    {
                                        bestScore = user.Score;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void LetsPushLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, k].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, k].Text = string.Empty;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    user.CalculateScore(number);
                                    if (user.Score > bestScore)
                                    {
                                        bestScore = user.Score;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void LetsPushUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[k, j].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[k, j].Text = string.Empty;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    user.CalculateScore(number);
                                    if (user.Score > bestScore)
                                    {
                                        bestScore = user.Score;
                                    }
                                }
                                break;
                            }

                        }
                    }
                }
            }
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void LetsPushDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[k, j].Text == labelsMap[i, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    labelsMap[k, j].Text = string.Empty;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    user.CalculateScore(number);
                                    if (user.Score > bestScore)
                                    {
                                        bestScore = user.Score;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
       
    }
}
