using System;

namespace CIT365_Hello_World_Assignment
{
    public class Program
    {
        public static void Main()
        {
            var name = "Brother Blazzard";
            Console.WriteLine($"Hello {name}!");
            // Using simple concatenation
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("Utah - United States of America");
            var currentDateTime = DateTime.Now;
            Console.WriteLine("Today is " + currentDateTime.ToString("dddd, MMMM dd, yyyy") + ".");
        }
    }
}
