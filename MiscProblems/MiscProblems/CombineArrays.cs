using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscProblems
{
    public static class CombineArrays
    {
        public static char[] CombineArrayNew(int[] a, char[] b)
        {
            //a = {5,3,2,1,4}
            //b =  {< < < <} 
            char[] output = new char[a.Length + b.Length];
            Array.Sort(a);
            if (a.Length >= 2 && b.Length >= 1)
            {
                int j = 1;
                for (int i = 0; i < b.Length; i++)
                {
                    output[j] = b[i];
                    j = j + 2;
                }
            }
            int minIndex = 0;
            int maxIndex = a.Length - 1;
            for (int j = 1; j < output.Length; j = j + 2)
            {
                if (output[j] == '>')
                {
                    output[j - 1] = (char)a[maxIndex];
                    maxIndex--;
                }
                else
                {
                    output[j - 1] = (char)a[minIndex];
                    minIndex++;
                }
            }
            output[output.Length - 1] = (char)a[minIndex];
            return output;
        }

    }
}
