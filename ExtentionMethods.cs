using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTasks
{
    static class ExtentionMethods
    {
        public static bool IsEven(int num)
        {
           return num % 2 == 0;
        }
        public static int[] GetValueIndex(int[] number,int a)
        {
            int[] result = new int[0];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == a)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = i;
                }
               
            }
            return result;
        }

    }
}
