using System.IO;

namespace FullStack_Task.HorizontalClasses
{
    public static class Files
    {
        public static bool Write(string filepath, string body)
        {
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            File.WriteAllText(filepath, body);
            return File.Exists(filepath);
        }

        public static string Read(string filepath)
        {
            string body = "";
            if (File.Exists(filepath))
            {
                using (StreamReader sr = File.OpenText(filepath))
                {
                    body = sr.ReadToEnd();
                }
            }
            return body;
        }

        public static bool Delete(string filepath)
        {
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            return File.Exists(filepath);
        }

        public static void Append(string filepath, string body)
        {
            if (File.Exists(filepath))
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.Write(body);
                }
            }
        }
    }
}
