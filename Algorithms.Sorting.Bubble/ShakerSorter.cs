using System.Numerics;

namespace Algorithms.Sorting
{
    public static class ShakerSorter
    {
        /// <summary>
        /// Simple sorting algorithm executing bubble sort from bottom to top on even passage and from top to botton on odd one.
        /// </summary>
        /// <typeparam name="T">Array entry type having comparison operators</typeparam>
        /// <param name="sortableArray">Array to sort</param>
        /// <param name="showSteps">Flag enabling printing values after each iteration and when swap is done</param>
        public static void ShakerSort<T>(this T[] sortableArray, bool showSteps = false)
            where T : INumber<T>, IComparisonOperators<T, T, bool>
        {
            if (sortableArray.Length == 0)
                return;

            var left = 0;
            var right = sortableArray.Length;

            for (int i = 0; i < sortableArray.Length; i++)
            {
                var swapped = false;
                for(int j = left; j < right - 1; j++)
                {
                    if (sortableArray[j] > sortableArray[j + 1])
                    {
                        swapped = true;
                        (sortableArray[j], sortableArray[j + 1]) = (sortableArray[j + 1], sortableArray[j]);
                        if (showSteps)
                        {
                            SortAlgorithmsHelper.PrintArrayAsChart(sortableArray, j, j + 1);
                            //Thread.Sleep(50);
                        }
                    }
                }
                right--;

                for (int j = right; j > left; j--)
                {
                    if (sortableArray[j - 1] > sortableArray[j])
                    {
                        swapped = true;
                        (sortableArray[j], sortableArray[j - 1]) = (sortableArray[j - 1], sortableArray[j]);
                        if (showSteps)
                        {
                            SortAlgorithmsHelper.PrintArrayAsChart(sortableArray, j, j-1);
                            //Thread.Sleep(50);
                        }
                    }
                }

                left++;
                if (showSteps)
                {
                    SortAlgorithmsHelper.PrintArrayAsChart(sortableArray);
                    //Thread.Sleep(50);
                }

                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
