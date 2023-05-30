using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    class Array : ICalc
    {
        private int[] arr;

        public Array(int[] arr)
        {
            this.arr = arr;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }

}