using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    public static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("==========================================");
        }

        public static void PrintSystemTitle(string title)
        {
            PrintSeparator();
            Console.WriteLine(title);
            PrintSeparator();
        }
    }
}
