﻿using System;

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
    }
}
