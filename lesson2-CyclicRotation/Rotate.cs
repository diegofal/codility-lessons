using System;

namespace Lesson2
{
    public class Rotate
    {
        public int[] RotateNumberArray(int [] A, int K)
        {
            var l = A.Length;
            var ret = new int[l];

            for(var i = 0; i < l; i++)
            {
                // calculate the element that needs to be on position i
                var t = i + Math.Abs(l - K);

                // if we exceed the length of the array, use mod to determine the position
                if (t > l - 1) t = t % l;

                // finally, set the element at position i
                ret[i] = A[t];
            }

            return ret;
        }
    }
}
