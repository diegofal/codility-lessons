using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new[] { 1, 2, 3, 4, 5 }; 
            Console.WriteLine(new Lesson2.Rotate().RotateNumberArray(num, 1));
        }
    }
}
