﻿using System;
using System.Numerics;

class SequenceOfFibonnaci
{
    static void Main()
    {
        //Write a program to print the first 100 members of the 
        //sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
        BigInteger a = 0;
        BigInteger b = 1;

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a + b;
            b = b + a;
        }
    }
}
