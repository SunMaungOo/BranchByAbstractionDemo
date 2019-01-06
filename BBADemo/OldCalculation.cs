using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBADemo
{
    public class OldCalculation : ICalculation
    {
        public int Calculate(int a, int b)
        {
            return Calculation.Calculate(a, b);
        }
    }
}
