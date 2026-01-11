namespace assignmnet13._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.txt";

            string content = File.ReadAllText(filePath);

            if (content.Length >= 7)   // safety check
            {
                string result = content.Substring(2, 5);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("File does not contain enough characters.");
            }
        }
    }
}