using GeniyIdiotCommon;
using System;


namespace GenIdiConsoleApp
{
    partial class Program
    {
        static string PathToDataFileWithResults = "FileWithResults.txt"; 
        static void Main(string[] args)
        {
            int numberForRepeat = 0;
            do
            {
                Console.WriteLine("Введите, пожалуйста, Ваше ФИО");
                var user = new User(Console.ReadLine());
                var game = new Game(user);                                                         
                             
                while (!game.IsEnd())
                {
                    Console.WriteLine(game.GetCurrentQuestionNumberInfo());
                    var randomQuestion = game.PopRandomQuestion();
                    Console.WriteLine(randomQuestion.Print());
                                       
                    int userAnswer = СheckUserAnswer();
                    game.AcceptUserAnswer(userAnswer);                    
                }

                var userDiagnose = game.GetUserDiagnose();
                Console.WriteLine(user.Print() + ", Ваш диагноз " + userDiagnose.Name);
                game.SaveUserResult();

                Console.WriteLine("Показать все результаты? Да - нажмите клавишу 1. Нет - любую другую клавишу");
                int numberForShowResults;
                int.TryParse(Console.ReadLine(), out numberForShowResults);
                if (numberForShowResults == 1)
                {
                    var data = game.GetUserResultFromFile();
                    for (int i = 0; i < data.Count; i++)
                    {
                        var stringToPrint = data[i];
                        Console.WriteLine(stringToPrint.Print());
                    }                    
                }                           
                
                Console.WriteLine("Если вы хотите пройти тест ещё раз - нажмите клавишу 1");
                Console.WriteLine("Для завершения тестирования - нажмите любую другую клавишу");
                int.TryParse(Console.ReadLine(), out numberForRepeat);
            }
            while (numberForRepeat == 1);      
        }
        
        static int СheckUserAnswer()
        {
            int userAnswer;
            while(!int.TryParse(Console.ReadLine(), out userAnswer))           
            {
                Console.WriteLine("Некорректный формат ответа. Введите число.");                
            }
            return userAnswer;
        }        
        
    }
        
}

 