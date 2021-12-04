using System;

namespace leetcode13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            int sum = 0;
            char[] chararray = s.ToCharArray();
            Console.WriteLine(chararray.Length);

            for (int i=0; i < chararray.Length; i++)
            {
                if (i != chararray.Length - 1)
                {
                    if (chararray[i] == 'I' && (chararray[i + 1] == 'V' || chararray[i + 1] == 'X'))
                    {
                        sum += number(chararray[i + 1]) - number(chararray[i]);
                        i++;
                    }
                    else if (chararray[i] == 'X' && (chararray[i + 1] == 'L' || chararray[i + 1] == 'C'))
                    {
                        sum += number(chararray[i + 1]) - number(chararray[i]);
                        i++;
                    }
                    else if (chararray[i] == 'C' && (chararray[i + 1] == 'D' || chararray[i + 1] == 'M'))
                    {
                        sum += number(chararray[i + 1]) - number(chararray[i]);
                        i++;
                    }
                    else
                    {
                        sum += number(chararray[i]);
                    }
                }
                else
                {
                    sum += number(chararray[i]);
                }
            }

            Console.WriteLine(sum);
        }
        static int number(char a)
        {
            int b = 0;
            switch (a)
            {
                case 'I':
                    b = 1;
                    break;
                case 'V':
                    b = 5;
                    break;
                case 'X':
                    b = 10;
                    break;
                case 'L':
                    b = 50;
                    break;
                case 'C':
                    b = 100;
                    break;
                case 'D':
                    b = 500;
                    break;
                case 'M':
                    b = 1000;
                    break;
                default:
                    b = 0;
                    break;
            }

            return b;
        }
    }
}
