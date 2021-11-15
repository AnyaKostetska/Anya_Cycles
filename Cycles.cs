using System;

namespace Anya_Cycles
{
    public class Cycles
    {
        public static double GetAToPowerB(double A, double B)
        {
            double count = 1;
            for (double i = 1; i <= B; i++)
            {
                count *= A;
            }

            return count;
        }

        public static double GetADevidedNumbers(double A)
        {
            double count = 1;
            for (double i = 1; i <= 1000; i++)
            {
                if (i % A == 0)
                {
                    count++;
                }
            }

            return count;
        }
        public static int GetPositiveNumbers(int A)
        {
            int count = 1;
            for (int i = 1; i > 0; i++)
            {
                if (i * i < A)
                {
                    count++;
                }
            }

            return count;
        }
        public static int GetADevider(int A)
        {
            int result = 1; 
                for (int i = A/2; i > 1; i--)
            {
                if (A% i == 0)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public static int Sum(int a, int b)
        {
            int divider = 7;
            int result = 0;

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            while (a % divider != 0)
            {
                ++a;
            }
            for (int i = a; i <= b; i += divider)
            {
                result += i;
            }

            return result;
        }

        public static int Fibbonachi(int N)
        {
            int result = 0;
            int x1 = 1;
            int x2 = 1;
            for (; N > 0; N -= 2)
            {
                if (N==1)
                {
                    result = x1;
                }
                else if (N == 2)
                {
                    result = x2;
                }
                x1 += x2;
                x2 += x1;
            }
            return result;
        }
    }
}
