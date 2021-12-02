using System;

namespace leetcode2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x =int.Parse(Console.ReadLine());
            int reminder;
            int x1 = x;
            int res = 0;
            for (; x1 != 0;)
            {
                if (res < int.MinValue / 10 || res > int.MaxValue / 10)
                {
                    res = 0;
                    break;
                }
                reminder = x1 % 10;
                x1 = x1 / 10;
                res = res * 10 + reminder;
            }
            return res;
        }
    }
}
