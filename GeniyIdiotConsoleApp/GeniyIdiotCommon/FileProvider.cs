using System.IO;
using System.Text;

namespace GeniyIdiotCommon
{     
    public class FileProvider
    {
        public static void Add(string path, string savedData)
        {
            using (var writer = new StreamWriter(path, true, Encoding.UTF8))
            {
                writer.WriteLine(savedData);
            }
        }
        public static void Save(string path, string savedData)
        {
            using (var writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                writer.WriteLine(savedData);
            }
        }
        public static string Get(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }
        public static bool TryGet(string path, out string data)
        {
            if (Exist(path))
            {
                data = Get(path);
                return true;
            }
            data = null;
            return false;
            
        }
        public static bool Exist(string path)
        {
            return File.Exists(path);
        }
    }
        
}

 