using System;

namespace Lesson3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(solution(10, 85, 30));
        }

        static public int solution(int X, int Y, int D)
        {
            if (Y - X < D) return 0;

            var steps = Math.Ceiling((decimal)(Y - X) / D);

            var end = X + (D * steps);

            return Convert.ToInt32(steps);
        }
    }
}