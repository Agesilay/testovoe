using System;
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
            for (int j = 1; j < N; j++){
                for (int i = 0; i < j; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Hello world!");
        }
    }
}
