using System;

namespace leetcode9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int rev = 0;
            int reminder = 0;
            int x1 = x;
            for (int i = 0; x1 > 0; i++)
            {
                reminder = x1 % 10;
                x1 = x1 / 10;
                rev = rev * 10 + reminder;
            }
            if (rev == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
