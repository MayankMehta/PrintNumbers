using System.Collections.Generic;
using System.Diagnostics;

namespace PrintNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 0, 2, 3, 6 };
            printNumbers(list);
        }

        private static void printNumbers(List<int> i)
        {
            foreach (int y in i)
            {
                if (y % 3 == 0 && y % 5 == 0)
                {
                    Debug.WriteLine("lutron");
                }
                else if (y % 3 == 0)
                {
                    Debug.WriteLine("lu");
                }
                else if (y % 5 == 0)
                {
                    Debug.WriteLine("tron");
                }
            }
        }
    }
}
