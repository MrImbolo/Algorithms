using System.Numerics;

namespace Algorithms.Sorting
{
    public static class CombSorter
    {
        /// <summary>
        /// Simple sorting algorithm swapping possible big values in the end of the array before executing bubble sort.
        /// </summary>
        /// <typeparam name="T">Array entry type having comparison operators</typeparam>
        /// <param name="sortableArray">Array to sort</param>
        /// <param name="showSteps">Flag enabling printing values after each iteration and when swap is done</param>
        public static void CombSort<T>(this T[] sortableArray, bool showSteps = false)
            where T : INumber<T>, IComparisonOperators<T, T, bool>
        {
            if (sortableArray.Length == 0)
                return;

            var factor = 1.2473309;
            var gap = sortableArray.Length - 1;

            while (gap > 1)
            {
                if (gap < 1) gap = 1;

                for (int i = 0; i + gap < sortableArray.Length - 1; i++)
                {
                    if (sortableArray[i] > sortableArray[i + gap])
                    {
                        (sortableArray[i + gap], sortableArray[i]) = (sortableArray[i], sortableArray[i + gap]);
                        if (showSteps)
                        {
                            SortAlgorithmsHelper.PrintArrayAsChart(sortableArray, i, i + gap);
                            //Thread.Sleep(500);
                        }
                    }
                }


                gap = (int)Math.Floor(gap / factor);
            }

            for (int i = 0; i < sortableArray.Length; i++)
            {
                var swapped = false;
                for (int j = 0; j < sortableArray.Length - 1 - i; j++)
                {
                    if (sortableArray[j] > sortableArray[j + 1])
                    {
                        (sortableArray[j + 1], sortableArray[j]) = (sortableArray[j], sortableArray[j + 1]);
                        swapped = true;
                        if (showSteps)
                        {
                            SortAlgorithmsHelper.PrintArrayAsChart(sortableArray, j, j + i);
                            //Thread.Sleep(500);
                        }
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
