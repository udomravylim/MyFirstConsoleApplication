using System;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ravy Lim";
            string location = "Cambodia";

            // Current date as DateTime
            DateTime currentDate = DateTime.Now.Date;

            // Correct DateTime constructor (year, month, day)
            DateTime christmasDay = new DateTime(currentDate.Year, 12, 25);

            // Calculate days until Christmas
            int daysUntilChristmas = (christmasDay - currentDate).Days;

            // Output
            Console.WriteLine($"My name is {name}, and I am from {location}.");
            Console.WriteLine($"Today's Date: {currentDate.ToString("MM-dd-yyyy")}");
            Console.WriteLine($"Days until Christmas: {daysUntilChristmas}");


            //call the GlazerCalc 
            GlazerCalc.Calculate();
        }
    };

    class GlazerCalc
    {
        public static void Calculate()
            
        {
            Console.WriteLine("Please enter the width of the window in meters: ");
            double width = double.Parse( Console.ReadLine() );

            Console.WriteLine("Please enter the hight of the window in metters: ");
            double height = double.Parse( Console.ReadLine() );
          
            double woodLength = 2 * (width + height) * 3.25;
            double glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press on any key to exit! ");
            Console.ReadKey();
        }
    }
}


