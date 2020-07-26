using Newtonsoft.Json;
using System.Collections.Generic;


namespace _2048ClassLibrary
{
    public class Game
    {
        public const string pathToDataFileWithBestScore = "FileWithBestScore.json";
        public const string pathToDataFileWithCommonUserResults = "FileWithCommonUserResults.json";
        public User user;
        public Game(User user)
        {
            this.user = user;           
            
        }
        public static void SaveBestScore(int bestScore)
        {
            BestScoreSaveToFile(bestScore);
        }
        public static void BestScoreSaveToFile(int bestScore)
        {
            var serializedResults = JsonConvert.SerializeObject(bestScore, Formatting.Indented);
            FileProvider.Save(pathToDataFileWithBestScore, serializedResults);
        }

        public void SaveUserResult(int currentScore)
        {
            var resultToSave = new UserResult(user.Name, user.Score);
            string dataToGet;
            var isExist = FileProvider.TryGet(pathToDataFileWithCommonUserResults, out dataToGet);
            var userResultsInFile = new List<UserResult>();
            if (isExist)
            {
                userResultsInFile = JsonConvert.DeserializeObject<List<UserResult>>(dataToGet);
            }
            userResultsInFile.Add(resultToSave);
            ResultsSaveToFile(userResultsInFile);                                
        }

        public List<UserResult> GetUserResultFromFile()
        {
            var userResults = new List<UserResult>();
            string dataToGet;
            var isExist = FileProvider.TryGet(pathToDataFileWithCommonUserResults, out dataToGet);            
            if (isExist)
            {
                userResults = JsonConvert.DeserializeObject<List<UserResult>>(dataToGet);
            }         
            
            return userResults;      
        }

        private void ResultsSaveToFile(List<UserResult> results)
        {
            var serializedResults = JsonConvert.SerializeObject(results, Formatting.Indented);
            FileProvider.Save(pathToDataFileWithCommonUserResults, serializedResults);
        }


    }
}
