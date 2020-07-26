using Newtonsoft.Json;
using System.Collections.Generic;


namespace GeniyIdiotCommon
{
    public class QuestionStorage
    {
        public const string PathToQuestionFile = "QuestionDataFile.json";

        public static List<Question> GetQuestions()
        {
            List<Question> Questions = new List<Question>();
            Questions.Add(new Question("сколько будет два плюс два умноженное на два?", 6));
            Questions.Add(new Question("бревно надо распилить на 10 частей. сколько надо сделать распилов?", 9));
            Questions.Add(new Question("на двух руках 10 пальцев. сколько пальцев на 5 руках?", 25));
            Questions.Add(new Question("укол делают каждые полчаса. сколько нужно минут для трёх уколов?", 60));
            Questions.Add(new Question("Пять свечей горело, дву потухли. Сколько свечей осталось?", 2));
            return Questions;            
        }
        public static List<Question> GetQuestionsFromFile()
        {
            var data = FileProvider.Get(PathToQuestionFile);
            var questions = JsonConvert.DeserializeObject<List<Question>>(data);
            return questions;
        }
    }
        
}

 