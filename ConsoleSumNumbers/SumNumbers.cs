using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class SumNumbers
    {
        public List<KeyValuePair<int, int>> GetSumNumbers(int[] ints, int sum)
        {
            List<KeyValuePair<int, int>> pairs = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[i] + ints[j] == sum)
                    {
                        pairs.Add(new KeyValuePair<int, int>(ints[i], ints[j]));
                    }
                }
            }
            
            return pairs;
        }
    }
}
