using System;

namespace Holiday
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the date leaving?");
            string answer = Console.ReadLine();
            DateTime departure = DateTime.Parse(answer);
            Console.WriteLine("You are leaving on a " + departure.DayOfWeek + ".");
            Console.ReadLine();
            Console.WriteLine("How many days will you be gone?");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("You will return on a {0}.", DayReturning(departure, days));
            Console.ReadLine();
        }
        // TODO: Create a method that takes the day you are leaving on vacation and how many days you will be gone and return the name of the day of the week you will return.
        public static string DayReturning(DateTime departure, int days)
        {
            DateTime returning = departure.AddDays(days);
            return returning.DayOfWeek.ToString();
        }
    }
}
