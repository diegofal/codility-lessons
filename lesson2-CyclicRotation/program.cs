using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new[] { 1, 1, 2, 3, 5 };
          
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(string.Join(",", new Rotate().RotateNumberArray(num, i)));
            }

            Console.ReadLine();
        }
    }
}
