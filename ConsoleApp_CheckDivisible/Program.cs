﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CheckDivisible
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else
                if (i%3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else
                if (i%5 == 0)
                {
                    Console.WriteLine("buzz");
                }

            }
            Console.Read();
        }
    }
}
