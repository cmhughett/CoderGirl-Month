using System;

namespace Month
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number of the month: ");

            string monthNumberInput = Console.ReadLine();
            int monthNumber = int.Parse(monthNumberInput);

            // Save the input to a variable.

            // Use the if statment to update the monthName variable based on the user's input.
            string monthName = string.Empty;

            if (monthNumber == 1 )
                {
                monthName = "January" ;
            }

            if (monthNumber == 2)
            {
                monthName = "February";
            }

            if (monthNumber == 3)
            {
                monthName = "March";
            }

            if (monthNumber == 4)
            {
                monthName = "April";
            }

            if (monthNumber == 5)
            {
                monthName = "May";
            }

            if (monthNumber == 6)
            {
                monthName = "June";
            }

            if (monthNumber == 7)
            {
                monthName = "July";
            }

            if (monthNumber == 8)
            {
                monthName = "August";
            }

            if (monthNumber == 9)
            {
                monthName = "September";
            }

            if (monthNumber == 10)
            {
                monthName = "October";
            }

            if (monthNumber == 11)
            {
                monthName = "November";
            }

            if (monthNumber == 12)
            {
                monthName = "December";
            }

            if (monthNumber >= 13)
            {
                Console.WriteLine("That is not a valid input.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine($"The name of the month you entered is {monthName}");

            Console.ReadLine();
        }
    }
}
