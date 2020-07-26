using System;

namespace GeniyIdiotCommon
{
    [Serializable()]
    public class UserResult
    {        
        public  string Name { get; set; }
        public  int NumberOfRightAnswers { get; set; }
        public  string DiagnoseName { get; set; }
        public string Print()
        {
            return ("Имя: " + Name + ", Количество правильных ответов: " + NumberOfRightAnswers + ", Диагноз: " + DiagnoseName);
        }
        public UserResult(string name, int numberOfRightAnsers, string diagnoseName)
        {
            Name = name;
            NumberOfRightAnswers = numberOfRightAnsers;
            DiagnoseName = diagnoseName;
        }
        
    }
}
