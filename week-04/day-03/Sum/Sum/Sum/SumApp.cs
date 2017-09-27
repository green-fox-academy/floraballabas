using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class SumApp
    {
        public int GetSum(List<int> sumList)
        {
            int sum = 0;
            if (sumList != null)
            {
                foreach (int number in sumList)
                {
                    sum += number;
                }
                return sum;
            }
            return 0;
        }
    }
}
