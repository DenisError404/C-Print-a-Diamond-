using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("By Denis Rafi");
            Console.WriteLine("-----------------");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}",
                new string('_', n / 2),
                new string('|', 1));//1ST PART - STATIC
            for (int i = 0; i < n / 2 - 1; i++)//2ND PART
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('_', (n / 2 - 1) - i),
                    new string('|', 1),
                    new string('_', 1 + 2 * i));
            }
            Console.WriteLine("{0}{1}{0}",
                new string('|', 1),
                new string('_', n - 2));//3RD PART - STATIC

            for (int i = 0; i < n / 2 - 1; i++)//4TH PART
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('_', i + 1),
                    new string('|', 1),
                    new string('_', (n - 4) - 2 * i));
            }
            Console.WriteLine("{0}{1}{0}",
                new string('_', n / 2),
                new string('|', 1));//5TH PART = 1ST PART- STATIC
            Console.ReadKey();
        }         
    }
}
