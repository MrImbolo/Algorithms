using System.Globalization;
using System.Numerics;

namespace Algorithms.Sorting
{
    public static class BubbleSorter
    {
        /// <summary>
        /// Simple sorting algorithm comparing closest entries of the array and swapping them if right is less then left. 
        /// </summary>
        /// <typeparam name="T">Array entry type having comparison operators</typeparam>
        /// <param name="sortableArray">Array to sort</param>
        /// <param name="showSteps">Flag enabling printing values after each iteration and when swap is done</param>
        public static void BubbleSort<T>(this T[] sortableArray, bool showSteps = false)
            where T : INumber<T>, IComparisonOperators<T, T, bool>
        {
            for (int i = 0; i < sortableArray.Length; i++)
            {
                var swapped = false;
                for (int j = 0; j < sortableArray.Length - 1 - i; j++)
                {
                    if (sortableArray[j] > sortableArray[j + 1])
                    {
                        (sortableArray[j + 1], sortableArray[j]) = (sortableArray[j], sortableArray[j + 1]);
                        swapped = true;
                        SortAlgorithmsHelper.PrintArrayAsChart(sortableArray, j, j + 1);
                        //Thread.Sleep(500);
                    }
                }
                if (showSteps)
                {
                    SortAlgorithmsHelper.PrintArrayAsChart(sortableArray);
                    //Thread.Sleep(500);
                }
                if (!swapped) break;
            }
        }
    }
}