﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDLecture
{
    //Factorize a positive integer number into its prime factors.

    //Use the TDD approach to write tests that call a single method `Factorize()`. Given a positive integer input n, return its prime factors.

    //1 is always omitted from the result set.
    //2 -> returns[2]
    //3 -> returns[3]
    //4 -> returns[2, 2]
    //6 -> returns[2, 3]
    //7 -> returns[7]
    //8 -> returns[2, 2, 2]
    //9 -> returns[3, 3]
    //10 -> returns[2, 5]
    //24 -> returns [2, 2, 2, 3]
    public class KataPrimeFactors
    {
        public int[] Factorize(long inputValue)
        {
            List<int> Factors = new List<int>();
            for (int i = 2; i <= inputValue; i++)
            {
                int[] factors = new int[0];
                if (inputValue % i == 0)
                {
                    while (inputValue % i == 0)
                    {
                        Factors.Add(i);
                        inputValue = inputValue / i;
                    }
                }
            }
            int[] FactorArray = Factors.ToArray();
            return FactorArray;

        }
    }
}
