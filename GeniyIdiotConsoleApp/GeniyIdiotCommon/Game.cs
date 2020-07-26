using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniyIdiotCommon
{
    public class Game
    {        
        private const string pathToDataFileWithResults = "FileWithResults.json";
        public User user;
        private List<Question> questions;
        private Question currentQuestion;
        private int questionNumber = 0;
        private int startCountQuestion;        
        

        public Game(User user)
        {
            this.user = user;
            Init();
            questions = QuestionStorage.GetQuestionsFromFile();
            startCountQuestion = questions.Count();
        }

        private void Init()
        {
            var isExist = FileProvider.TryGet(QuestionStorage.PathToQuestionFile, out var questionData);
            if(!isExist)
            {
                questions = QuestionStorage.GetQuestions();
                QuestionsSaveToFile(questions);
            }
        }

        public static void QuestionsSaveToFile(List<Question> questions)
        {
            var serializedQuestions = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Save(QuestionStorage.PathToQuestionFile, serializedQuestions);
        }
        private void ResultsSaveToFile(List<UserResult> results)
        {
            var serializedResults = JsonConvert.SerializeObject(results, Formatting.Indented);
            FileProvider.Save(pathToDataFileWithResults, serializedResults);
        }

        public Question PopRandomQuestion()
        {
            var random = new Random();
            var randomQuestionIndex = random.Next(GetQuestionsCount());
            currentQuestion = questions[randomQuestionIndex];
            questions.Remove(currentQuestion);            
            return currentQuestion;
        }      

        public bool IsEnd()
        {
            return GetQuestionsCount() == 0;
        }

        public string GetCurrentQuestionNumberInfo()
        {
            questionNumber++;
            return "Вопрос №" + questionNumber;            
        }

        public void AcceptUserAnswer(int userAnswer)
        {
            int rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.AddRightAnswer();
            }
        }

        public Diagnose GetUserDiagnose()
        {
            var userDiagnose = DiagnoseCalculator.Calculate(user, startCountQuestion);
            user.SetDiagnose(userDiagnose);
            return userDiagnose;
        }

        public void SaveUserResult()
        {
            var resultToSave = new UserResult(user.Name, user.NumberOfRightAnswers, user.Diagnose.Name);
            var isExist = FileProvider.TryGet(pathToDataFileWithResults, out _);
            var userResultsInFile = new List<UserResult>();
            if (isExist)
            {
                userResultsInFile = GetUserResultFromFile();
            }
            userResultsInFile.Add(resultToSave);
            ResultsSaveToFile(userResultsInFile);
        }
        public List<UserResult> GetUserResultFromFile()
        {
            var userResults = new List<UserResult>();
            var isExist = FileProvider.TryGet(pathToDataFileWithResults, out _);
            if (isExist)
            {                
                var dataToGet = FileProvider.Get(pathToDataFileWithResults);                
                userResults = JsonConvert.DeserializeObject<List<UserResult>>(dataToGet);
                return userResults;                
            }
            return userResults;
        }        

        private int GetQuestionsCount()
        {
            return questions.Count;
        }
        
    }
}
