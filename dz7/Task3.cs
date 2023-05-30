using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    public class _Array : ICalc2
    {
        private int[] data;

        public _Array(int[] data)
        {
            this.data = data;
        }

        public int CountDistinct()
        {
            HashSet<int> v = new HashSet<int>();
            foreach (int value in data)
            {
                v.Add(value);
            }
            return v.Count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int value in data)
            {
                if (value == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }

}