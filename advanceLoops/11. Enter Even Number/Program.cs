﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: {0}", n);
                    break;

                }
                else Console.WriteLine("The number is not even.");

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
                throw;
            }
            
           
        }
    }
}
