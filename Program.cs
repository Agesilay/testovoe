using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testovoe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            UserValidator asdf = new UserValidator();

            if (asdf.IsEmailValid("adsf"))
            {
                Console.WriteLine("correct");
            }
            Console.WriteLine("Test string");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hello world!");
        }
    }
}
