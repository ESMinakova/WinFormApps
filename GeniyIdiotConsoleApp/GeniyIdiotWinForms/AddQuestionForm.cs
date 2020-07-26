using GeniyIdiotCommon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeniyIdiotWinForms
{
    public partial class AddQuestionForm : Form
    {
        Game game;
        public AddQuestionForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void saveQustionButton_Click(object sender, EventArgs e)
        {
            var text = questionTextTextBox.Text;
            var answer = questionAnswerTextBox.Text;
            if (IsValid (text, answer))
            {
                AddQuestion(text, int.Parse(answer));
                Close();
            }            
        }

        private bool IsValid(string text, string answer)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Введите текст вопроса");
                return false;
            }
            if (!int.TryParse(answer, out var result))
            {
                MessageBox.Show("Введите число, являющееся ответом");
                return false;
            }
            return true;
        }
        public void AddQuestion(string text, int answer)
        {
            var newQuestion = new Question(text, answer);
            var allQuestions = QuestionStorage.GetQuestionsFromFile();
            if (IsUniqueQuestion(allQuestions, newQuestion))
            {
                allQuestions.Add(newQuestion);
                Game.QuestionsSaveToFile(allQuestions);
            }
            else
            {
                MessageBox.Show("Такой вопрос уже существует!");
            }
        }
        private static bool IsUniqueQuestion(List<Question> allQuestions, Question newQuestion)
        {
            foreach (var question in allQuestions)
            {
                if (question.Text == newQuestion.Text && question.Answer == newQuestion.Answer)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
