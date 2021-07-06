using System;

namespace Number.Logic
{
    public static class NumberPropertie
    {
        public static bool IsPerfect(long number)
        {
            long sum = 0;
            for (int i = 1; i <= number/2; i++)
            {
                if (number % i == 0) sum += i;

            }
            return sum == number;
        }
        public static bool IsPrme(long number)
        {
            if (number == 1 || number == 2 || number == 3 || number == 5 || number == 7 || number == 9) return true;
            if(number%2==0) return false;
            if (number % 3 == 0) return false;
            if (number % 5 == 0) return false;
            if (number % 7 == 0) return false;
            if (number % 11 == 0) return false;
            return true;
        }
    }
}
