using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    public enum TransportEnum
    {
        Car,
        Bus,
        Subway,
        Bike,
        Walk
    }

    public static class TransportEnumExtensions
    {
        public static char GetChar(this TransportEnum transport)
        {
            switch (transport)
            {
                case TransportEnum.Car: return 'C';
                case TransportEnum.Bike: return 'B';
                case TransportEnum.Subway: return 'S';
                case TransportEnum.Bus: return 'U';
                case TransportEnum.Walk: return 'W';
                default: throw new Exception("Unkown transport");
            }
        }

        public static ConsoleColor GetColor(this TransportEnum transport)
        {
            switch (transport)
            {
                case TransportEnum.Bike: return ConsoleColor.Blue;
                case TransportEnum.Bus: return ConsoleColor.DarkGreen;
                case TransportEnum.Car: return ConsoleColor.Red;
                case TransportEnum.Subway: return ConsoleColor.DarkMagenta;
                case TransportEnum.Walk: return ConsoleColor.DarkYellow;
                default: throw new Exception("Unknown transport");
            }
        }
    }
    public static class Transportation
    {
        public static string[] GetMonthNames()
        {
                string[] names = new string[12];
                for (int month = 1; month <= 12; month++)
                {
                    DateTime firstDay = new DateTime(
                    DateTime.Now.Year, month, 1);
                    string name = firstDay.ToString("MMMM",
                    CultureInfo.CreateSpecificCulture("en"));
                    names[month - 1] = name;
                }
                return names;
        }

        public static void RunTransport()
        {
            Random random = new Random();
            int transportTypesCount = Enum.GetNames(typeof(TransportEnum)).Length;
            TransportEnum[][] transport = new TransportEnum[12][];

            for (int month = 1; month <= 12; month++)
            {
                int daysCount = DateTime.DaysInMonth(DateTime.Now.Year, month);

                transport[month - 1] = new TransportEnum[daysCount];

                for (int day = 1; day <= daysCount; day++)
                {
                    int randomType = random.Next(transportTypesCount);
                    transport[month - 1][day - 1] = (TransportEnum)randomType;
                }
            }

            string[] monthNames = GetMonthNames();
            int monthNamesPart = monthNames.Max(n => n.Length) + 2;
            for (int month = 1; month <= transport.Length; month++)
            {
                Console.Write($"{monthNames[month - 1]}:".PadRight(monthNamesPart));

                for (int day = 1; day <= transport[month - 1].Length; day++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor =
                    transport[month - 1][day - 1].GetColor();
                    Console.Write(transport[month - 1][day - 1].GetChar());
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                }

                Console.WriteLine();

            }



        }
    }
}
