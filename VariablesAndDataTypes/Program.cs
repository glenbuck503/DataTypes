﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your Name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            int currentAge = 33;
            string yearsOld = currentAge.ToString();
            Console.WriteLine(yearsOld);
            Console.ReadLine();

            bool isRaining = true;
            string RainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(RainingStatus);
            Console.ReadLine();



            
        }
    }
}
