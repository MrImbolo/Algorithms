using System.Numerics;

namespace Algorithms.Sorting
{
    public static class InsertionSorter
    {
        /// <summary>
        /// Simple sort algorithm taking each element of the array and moving up all entries with value and index less then selected.
        /// </summary>
        /// <typeparam name="T">Array entry type having comparison operators</typeparam>
        /// <param name="sortableArray">Array to sort</param>
        /// <param name="showSteps">Flag enabling printing values after each iteration and when swap is done</param>
        public static void InsertionSort<T>(this T[] sortableArray, bool showSteps = false)
            where T : INumber<T>, IComparisonOperators<T, T, bool>
        {
            if (sortableArray.Length == 0)
                return;

            for (int i = 1; i < sortableArray.Length; i++)
            {
                var item = sortableArray[i];
                var j = i;
                while (j > 0 && item < sortableArray[j-1])
                {
                    sortableArray[j] = sortableArray[j - 1];
                    j--;
                }
                sortableArray[j] = item;

                if (showSteps)
                {
                    SortAlgorithmsHelper.PrintArrayAsChart(sortableArray, i);
                    //Thread.Sleep(500);
                }
            }
        }
    }
}
