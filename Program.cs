﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;

namespace testovoe
{
    class Program
    {
        public const int N = 10;

        static void Main(string[] args)
        {

            MessageBox.Show("Testing...");
            Console.WriteLine("Test string");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hello world!");
        }
    }
}
