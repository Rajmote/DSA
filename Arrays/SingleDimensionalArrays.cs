using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class SingleDimensionalArrays
    {
        public static void MonthArray()
        {
            int[] numbers = new int[] { 9, -11, 6, -12, 1 };
            //int[] numbers = { 9, -11, 6, -12, 1 };

            string[] months = new string[12];
            for (int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
                months[month - 1] = name;
            }
            foreach (string month in months)
            {
                Console.WriteLine($"-> {month}");
            }

        }
    }
}
