﻿using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                // 2 exemples de string concatenation
                Console.WriteLine("Hello " + args[0] + "!");
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello !");
            }
        }
    }
}