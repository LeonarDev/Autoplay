using System;
using Humanizer;

namespace DotNetDependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;
            
            Console.WriteLine("Quantities:");
            HumanizeQuantities();

            Console.WriteLine("Date/Time Manipulation:");
            HumanizeDates();

            static void HumanizeQuantities() {
                System.Console.WriteLine("case".ToQuantity(0));
                System.Console.WriteLine("case".ToQuantity(1));
                System.Console.WriteLine("case".ToQuantity(5));
                System.Console.WriteLine();
            }

            static void HumanizeDates() {
                System.Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
                System.Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
                System.Console.WriteLine(TimeSpan.FromDays(1).Humanize());
                System.Console.WriteLine(TimeSpan.FromDays(16).Humanize());
                System.Console.WriteLine();
            }
        }
    }
}
