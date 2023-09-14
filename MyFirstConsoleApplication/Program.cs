using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName, myLocation;
            myName = "Ben";
            myLocation = "Dayton, OH";
            Console.WriteLine($"My name is {myName}, I am from {myLocation}");
            Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
