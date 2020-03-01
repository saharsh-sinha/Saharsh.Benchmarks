using System;

namespace Saharsh.Benchmarks.CSharp.lib
{
    public class MergeSort
    {
        public int[] Sort(int[] unsorted)
        {
            int arrayLength = unsorted.Length;
            if (arrayLength < 2)
                return unsorted;

            int array1Length = arrayLength / 2;
            int array2Length = arrayLength - array1Length;

            int[] array1 = new int[array1Length];
            int[] array2 = new int[array2Length];
            Array.Copy(unsorted, 0, array1, 0, array1Length);
            Array.Copy(unsorted, array1Length, array2, 0, array2Length);

            array1 = Sort(array1);
            array2 = Sort(array2);

            return Merge(array1, array2);
        }

        private int[] Merge(int[] array1, int[] array2)
        {
            int a1Length = array1.Length;
            int a2Length = array2.Length;
            int a1i = 0;
            int a2i = 0;
            int ai = 0;
            
            int[] sorted = new int[a1Length + a2Length];

            while (a1i < a1Length || a2i < a2Length)
            {
                if (a1i < a1Length && a2i < a2Length)
                {
                    if (array1[a1i] < array2[a2i])
                    {
                        sorted[ai] = array1[a1i];
                        a1i++;
                        ai++;
                    }
                    else
                    {
                        sorted[ai] = array2[a2i];
                        a2i++;
                        ai++;
                    }
                }
                else if (a1i < a1Length)
                {
                    sorted[ai] = array1[a1i];
                    a1i++;
                    ai++;
                }
                else 
                {
                    sorted[ai] = array2[a2i];
                    a2i++;
                    ai++;
                }
            }

            return sorted;
        }
    }
}
