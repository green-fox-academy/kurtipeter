using System;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {

            Reservation reservation = new Reservation();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(reservation.Book());
            }
            Console.ReadLine();
        }
    }
}
