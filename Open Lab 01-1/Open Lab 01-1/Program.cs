using System;

namespace Open_Lab_01_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 10)
            {
                Console.WriteLine("This number is less then 10");
            }
            else
            {
                Console.WriteLine("This number is greater or equal to 10");
            }
        }
    }
}
