namespace ConsoleApp2
{
    class Program
    {
        interface IMammals
    {
        int GetBodyTemp(string value);
    }

    
    abstract class Animals : IMammals
    {
        public abstract int GetBodyTemp(string value);
    }

   
    class MyAnimals : Animals
    {
        
        private int bodyTemp;

        public int BodyTemp
        {
            get { return bodyTemp; }
            set { bodyTemp = value; }
        }

    
        public override int GetBodyTemp(string value)
        {
            
            return BodyTemp;
        }
    }

   
   
        static void Main(string[] args)
        {
            MyAnimals obj = new MyAnimals();

            Console.Write("Enter Body Temperature: ");
            obj.BodyTemp = Convert.ToInt32(Console.ReadLine());

            
            int temp = obj.GetBodyTemp("input");

            Console.WriteLine("Body Temperature: " + temp);
        }
    }
}
