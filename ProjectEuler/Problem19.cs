using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem19
    {
        // How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

        public static void Run()
        {
            int count = 0;
            // nested loop to iterate through every year and month in the twentieth century (1901-2000).
            // It creates a DateTime object for the first day of each month, and checks whether it falls on a Sunday by checking its DayOfWeek property.
            // If the day is a Sunday, the program increments a counter
            for (int year = 1901; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    DateTime date = new DateTime(year, month, 1);
                    if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("The number of Sundays that fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000) is: " + count);
            Console.ReadLine();
        }
    }
}