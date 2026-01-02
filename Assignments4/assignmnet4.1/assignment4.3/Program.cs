namespace assignment4._3
{

    //array to  seperate odd and even 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  size  of  array");
            int sizeArr=int.Parse(Console.ReadLine());

            int [] arr =new int[sizeArr];

            for (int i = 0;i< sizeArr;i++)
            {
                arr[i] = i;
            }
            for (int j=0;j<sizeArr;j++)
            {
                Console.WriteLine(arr[j]);
            }


        }
    }
}
