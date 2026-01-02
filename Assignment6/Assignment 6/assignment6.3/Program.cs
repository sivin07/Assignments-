using System.Security.Cryptography.X509Certificates;

namespace assignment6._3
{
    internal class Program
    {

        class MovieTicket
        {
            public string movieName;
            public int totalSeats;
            public int bookedSeats;

            // Constructor
            public MovieTicket(string movieName, int totalSeats, int bookedSeats)
            {
                this.movieName = movieName;
                this.totalSeats = totalSeats;
                this.bookedSeats = bookedSeats;
            }

            // Book seats
            public void BookSeats(int seats)
            {
                int availableSeats = totalSeats - bookedSeats;

                if (seats > 0 && seats <= availableSeats)
                {
                    bookedSeats += seats;
                }
                else
                {
                    Console.WriteLine("Seats not available for booking");
                }
            }

            // Cancel seats
            public void CancelSeats(int seats)
            {
                if (seats > 0 && seats <= bookedSeats)
                {
                    bookedSeats -= seats;
                }
                else
                {
                    Console.WriteLine("Cannot cancel more than booked seats");
                }
            }

            // Show booking status
            public override string ToString()
            {
                return "Movie Name: " + movieName +
                       "\nTotal Seats: " + totalSeats +
                       "\nBooked Seats: " + bookedSeats +
                       "\nAvailable Seats: " + (totalSeats - bookedSeats);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter movie name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter total seats:");
            int totalSeats = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter initially booked seats:");
            int bookedSeats = int.Parse(Console.ReadLine());

            MovieTicket ticket = new MovieTicket(name, totalSeats, bookedSeats);

            Console.WriteLine("Enter seats to book:");
            int book = int.Parse(Console.ReadLine());
            ticket.BookSeats(book);

            Console.WriteLine("Enter seats to cancel:");
            int cancel = int.Parse(Console.ReadLine());
            ticket.CancelSeats(cancel);

            Console.WriteLine("\nBooking Status:");
            Console.WriteLine(ticket);

            Console.ReadKey();
        }
    }
}