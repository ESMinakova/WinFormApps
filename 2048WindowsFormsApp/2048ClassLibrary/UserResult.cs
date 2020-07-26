

namespace _2048ClassLibrary
{
    public class UserResult
    {
        public string Name { get; set; }
        public int Score { get; set; }        
        
        public UserResult(string name, int score)
        {
            Name = name;
            Score = score;            
        }
        public UserResult()
        {
            Name = "";
            Score = 0;
        }
    }
}
