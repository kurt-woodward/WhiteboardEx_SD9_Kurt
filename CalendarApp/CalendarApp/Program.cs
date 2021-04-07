using System;

namespace CalendarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calendar());
        }

        static string calendar(string input = "April")
        {
            string todaysMonth = DateTime.UtcNow.ToString("MMMM");
            string monthName = input;
            string todaysDate = DateTime.UtcNow.ToString("dd");
            
            string[] week1 = new string[7];
            string[] week2 = new string[7];
            string[] week3 = new string[7];
            string[] week4 = new string[7];
            string[] week5 = new string[7];
            string monthString = monthName.ToUpper() + "\n" + dayNames; //+ $"\n{week1}\n{week2}\n{week3}\n{week4}\n{week5}\n";


            return monthString;
        }

        static string dayNames =
            "Sun " +
            "Mon " +
            "Tue " +
            "Wed " +
            "Thu " +
            "Fri " +
            "Sat\n";

        static int getNumOfDays(string monthName)
        {
            int numOfDays = 0;
            if (monthName == "February")
            {
                numOfDays = 28;
            }
            else if (monthName == "January" || monthName == "March" || monthName == "May" || monthName == "July" || monthName == "August" || monthName == "October" || monthName == "December")
            {
                numOfDays = 31;
            }
            else
            {
                numOfDays = 30;
            }
            return numOfDays;
        }

        static int monthStartDay(int today, int numOfDays)
        {
            int indexOfDay = 0;
            string todaysDay = DateTime.UtcNow.ToString("dd");

            return indexOfDay;
        }
    }
}
