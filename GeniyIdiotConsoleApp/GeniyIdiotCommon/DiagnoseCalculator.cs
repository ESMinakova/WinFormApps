using System;
using System.Collections.Generic;

namespace GeniyIdiotCommon
{
    public class DiagnoseCalculator
    {
        
        public static List<Diagnose> diagnoses = new List<Diagnose>();               
        public static List<Diagnose> GetDiagnose()
        {
            diagnoses.Add(new Diagnose("Идиот"));
            diagnoses.Add(new Diagnose("Кретин"));
            diagnoses.Add(new Diagnose("Дурак"));
            diagnoses.Add(new Diagnose("Нормальный"));
            diagnoses.Add(new Diagnose("Талант"));
            diagnoses.Add(new Diagnose("Гений"));        
            return diagnoses;            
        }

        public static Diagnose Calculate(User user, int countQuestions)
        {
            var percentOfRightAnswers = ((Convert.ToDouble(user.NumberOfRightAnswers) / Convert.ToDouble(countQuestions)) * 100);
            var counterForDiagnoses = (Convert.ToInt32(percentOfRightAnswers) / 20);
            var numberofDiagnoses = GetDiagnose().Count;
            var userDiagnose = new Diagnose();
            for (int i = 0; i < numberofDiagnoses; i++)
            {
                if (i == counterForDiagnoses)
                {
                    userDiagnose = diagnoses[i];
                }                
            }
            return userDiagnose;
        }
    }
       
}
