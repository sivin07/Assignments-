namespace assignment13
{
    public  class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.txt";
            string textToAppend = "\nThis text is appended.";//Others can only READ
            {

                using (FileStream filestream = new FileStream(filePath,FileMode.Append,FileAccess.Write,FileShare.Read))   
                using (StreamWriter writer = new StreamWriter(filestream))
                {
                    writer.WriteLine(textToAppend);
                }
            }

            Console.WriteLine("Text appended successfully.");
        }
    }
}
