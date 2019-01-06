﻿using FeatureSwitcher;
using FeatureSwitcher.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBADemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Features.Are.AlwaysEnabled();

            var toggle = new MyToggle();

            ICalculation calculation = null;

            if(toggle.Is().Disabled)
            {
                calculation = new OldCalculation();
            }
            else
            {
                calculation = new NewCalculation();
            }

            int a = 10;

            int b = 5;

            int result = calculation.Calculate(a, b);

            Console.WriteLine(string.Format("Result:{0}",result));
            Console.WriteLine("Program End");
            Console.ReadLine();
        }
    }
}
