using GeniyIdiotCommon;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinForms
{
    public partial class Main : Form
    {
        Game game;
        string userName;        
        public Main(string userName)
        {
            InitializeComponent();
            
            this.userName = userName;
        }
        
        public Main()
        {
            InitializeComponent();                       
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var user = new User(userName);
            game = new Game(user);            

            PrintNextQuestion();
        }

        private void questionNextButton_Click(object sender, EventArgs e)
        {
           
            int userAnswer;
            if (!int.TryParse(userAnswerTextBox.Text, out userAnswer))
            {
                MessageBox.Show("Некорректный формат ответа. Введите число.");
                return;
            }
            game.AcceptUserAnswer(userAnswer); 
            PrintNextQuestion();
            
        }       
        private void PrintNextQuestion()
        {
            if (game.IsEnd())
            {
                var userDiagnose = game.GetUserDiagnose();
                var formatedDiagnose = (game.user.Print() + ", Ваш диагноз " + userDiagnose.Name);
                MessageBox.Show(formatedDiagnose);
                game.SaveUserResult();                
                return;
            }
            questionNumberLabel.Text = game.GetCurrentQuestionNumberInfo();
            var question = game.PopRandomQuestion();                       
            questionTextLabel.Text = question.Print();
            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
        }

        private void показатьРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userResultsForm = new UserResultsForm(game.GetUserResultFromFile());
            userResultsForm.Show();
                        
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void пройтиЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddQuestionForm(game);
            addQuestionForm.Show();
        }
    }
}


