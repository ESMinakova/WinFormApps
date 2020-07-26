namespace GeniyIdiotCommon
{
    public class User
    {
        public string Name { get; }

        public int NumberOfRightAnswers { get; private set; }

        public Diagnose Diagnose { get; private set; }

        public User(string name)
        {
            Name = name;
            NumberOfRightAnswers = 0;
        }
        public User()
        {
            Name = "Неизвестно";
            NumberOfRightAnswers = 0;
        }
        public string Print()
        {
            return Name;
        }
        public void AddRightAnswer()
        {
            NumberOfRightAnswers++;
        }
        public void SetDiagnose(Diagnose diagnose)
        {
            Diagnose = diagnose;
        }
    }    
        
}

 