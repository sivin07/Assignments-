namespace Assignment1
{

class Program
{
    static void Main()
    {
        Console.Write("Enter distance in kilometers: ");
        double distance = double.Parse(Console.ReadLine());

        Console.Write("Enter time in hours: ");
        double time = double.Parse(Console.ReadLine());

        double speedKmph = distance / time;
        double speedMph = speedKmph * 0.621371;

        Console.WriteLine("Speed in km/h: " + speedKmph);
        Console.WriteLine("Speed in miles/h: " + speedMph);

        Console.ReadKey();
    }
}
}
