﻿using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
