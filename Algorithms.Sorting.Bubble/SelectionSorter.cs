using System.Numerics;

namespace Algorithms.Sorting
{
    public static class SelectionSorter
    {
        /// <summary>
        /// Simple sorting algorithm finding minimal entry of the array's subset from current 
        /// index to the end and swapping it with the current index if found
        /// </summary>
        /// <typeparam name="T">Array entry type having comparison operators</typeparam>
        /// <param name="sortableArray">Array to sort</param>
        /// <param name="showSteps">Flag enabling printing values after each iteration and when swap is done</param>
        public static void SelectionSort<T>(this T[] sortableArray, bool showSteps = false)
            where T : INumber<T>, IComparisonOperators<T, T, bool>
        {
            if (sortableArray.Length == 0)
                return;

            for (int i = 0; i < sortableArray.Length - 1; i++)
            {
                var indexOfMin = i;

                for (int j = indexOfMin + 1; j < sortableArray.Length; j++)
                {
                    if (sortableArray[j] < sortableArray[indexOfMin])
                    {
                        indexOfMin = j;
                    }
                }

                if (indexOfMin != i)
                {
                    (sortableArray[indexOfMin], sortableArray[i]) = (sortableArray[i], sortableArray[indexOfMin]);
                }

                if (showSteps)
                {
                    SortAlgorithmsHelper.PrintArrayAsChart(sortableArray, i);
                    //Thread.Sleep(500);
                }
            }
        }
    }
}
