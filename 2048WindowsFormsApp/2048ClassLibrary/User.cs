

namespace _2048ClassLibrary
{
    public class User
    {
        public string Name { get; }

        public int Score{ get; private set; }

        public int CalculateScore(int number)
        {
            if (number >= 0)
            {
                Score += number * 2;
            }
            return Score;
        }


        public  User(string name)
        {
            Name = name;
            Score = 0;
        }
        public User()
        {
            Name = "Неизвестно";
            Score = 0;
        }
        public string Print()
        {
            return Name;
        }
        
    }
}
