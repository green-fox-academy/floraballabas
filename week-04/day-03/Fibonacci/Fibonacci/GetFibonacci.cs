using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class GetFibonacci
    {
        public int Recursion(int n)
        {
            if (n < 2)
                return n;
            return Recursion(n - 2) + Recursion(n - 1);
        }
    }
}
