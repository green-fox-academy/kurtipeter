using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations
{
    class Reservation : IReservationy
    {
        public string GetCodeBooking()
        {
            string output = string.Empty;

            for (int i = 0; i < 8; i++)
            {
                Random r = new Random();
                char bigLetter = (char)r.Next(65, 91);
                char number = (char)r.Next(48, 58);

                if (r.Next(0, 2) == 1)
                {
                    bigLetter = (char)r.Next(65, 91);
                    output += bigLetter;
                }
                else
                {
                    number = (char)r.Next(48, 58);
                    output += number;
                }
            }
            return output;
        }

        public string GetDowBooking()
        {
            string[] doW = new string[7] { "MON", "TUE", "WED", "THU", "FRY", "SAT", "SUN" };
            Random random = new Random();

            string output = doW[random.Next(0,6)];
            return output;
        }

        public string Book()
        {
            string output = string.Format("Booking# {0} for {1}", GetCodeBooking(), GetDowBooking());
            return output;
        }
    }
}
