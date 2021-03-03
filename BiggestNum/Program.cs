using System;

namespace BiggestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The largest number is:" + biggestNumber());
        }

        static int[] array = { 190, 291, 145, 209, 280, 300 };

        public static int biggestNumber()
        {

            var maxNumber = array[0];

            var i = 0;

            for (i = 1; i < array.Length; i++)
                if (array[i] > maxNumber)
                    maxNumber = array[i];

            return maxNumber;
        }
    }
}
