using System.Collections.Generic;
using System.Diagnostics;

namespace PrintNumbersRecursive
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 1;
            printNumbers(i);
        }

        private static void printNumbers(int y)
        {
            if (y == 101)
            {
                Debug.WriteLine("END!" + y);
                return;
            }

            if (y % 3 == 0 && y % 5 == 0)
            {
                Debug.WriteLine("lutron" + y);
            }
            else if (y % 3 == 0)
            {
                Debug.WriteLine("lu" + y);
            }
            else if (y % 5 == 0)
            {
                Debug.WriteLine("tron" + y);
            }
            y++;
            printNumbers(y);
        }
    }
}
