﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fact = 1;
            for (int i = n; i >1; i--)
            {
                fact  *= i;
                
            }

            Console.WriteLine(fact);
        }
    }
}
