using System.Numerics;
using System.Text;

namespace Algorithms.Sorting
{
    public static class SortAlgorithmsHelper
    {
        private static int[] _array = null!;
        private static int[] _addedLines = Array.Empty<int>();
        public static int[] GetSampleArrayCopy(int length, int minValue = 0, int maxValue = 100)
        {
            _array ??= Enumerable.Range(0, length).Select(x => Random.Shared.Next(minValue, maxValue)).ToArray();

            var sortableArray = new int[_array.Length];
            _array.CopyTo(sortableArray, 0);

            return sortableArray;
        }
        public static void ResetArrayPrinter()
        {
            _addedLines = Array.Empty<int>();
        }
        public static void PrintArrayAsChart<T>(T[] array, params int[] heighlightIds)
            where T : INumber<T>, IComparisonOperators<T, T, bool>
        {
            // 1,2,3 -> | i
            //     O    | 0
            //   O O    | 1
            // O O O    | 2
            Console.SetCursorPosition(0, Console.CursorTop - _addedLines.Length);

            var max = (int)(object)array.Max()!;
            var width = max.Digits();
            var sb = new StringBuilder();

            for (int i = 0; i < max; i++)
            {
                var shift = max - i;
                sb.Append(' ', width - shift.Digits()).Append(shift).Append(" |");
                for (int j = 0; j < array.Length; j++)
                {
                    int a = (int)(object)array[j];
                    var isFilled = shift <= a;
                    if (isFilled)
                    {
                        sb.Append(' ', width - 1).Append(heighlightIds.Contains(j) ? '@' : 'O').Append(' ');
                    }
                    else
                    {
                        sb.Append(' ', width).Append(' ');
                    }
                }
                sb.AppendLine();
            }
            sb.Append('—', width + 1).Append('+').Append('—', (width + 1) * array.Length);
            sb.Append('\n').Append(' ', width).Append(" |");

            foreach (object a in array)
            {
                var n = (int)a;
                sb.Append(' ', width - n.Digits()).Append(n).Append(' ');
            }
            var output = sb.ToString();
            Console.WriteLine(output);

            _addedLines = output.Split('\n').Select(x => x.Length).ToArray();
        }
        public static void AssertSorted(int[] sorted, string messageOnFail)
        {
            var sortedList = new Span<int>(new int[sorted.Length]);
            sorted.AsSpan().CopyTo(sortedList);
            sortedList.Sort();


            for (int i = 0; i < sorted.Length; i++)
            {
                if (sortedList[i] != sorted[i])
                {
                    throw new Exception(messageOnFail + $"Element at [{i}] is ({sorted[i]}) while expected ({sortedList[i]})");
                }
            }
        }

        public static int Digits(this int n)
        {
            return n switch
            {
                < 10 and > -10 => 1,
                < 100 and > -100 => 2,
                < 1000 and > -1000 => 3,
                < 10000 and > -10000 => 4,
                < 100000 and > -100000 => 5,
                < 1000000 and > -1000000 => 6,
                < 10000000 and > -10000000 => 7,
                < 100000000 and > -100000000 => 8,
                < int.MaxValue and > int.MinValue => 9,
                _ => throw new ArgumentOutOfRangeException(nameof(n)),
            };
        }
        private static int Digits(this long n)
        {
            return n switch
            {
                < 10L and > -10L => 1,
                < 100L and > -100L => 2,
                < 1000L and > -1000L => 3,
                < 10000L and > -10000L => 4,
                < 100000L and > -100000L => 5,
                < 1000000L and > -1000000L => 6,
                < 10000000L and > -10000000L => 7,
                < 100000000L and > -100000000L => 8,
                < 1000000000L and > -1000000000L => 9,
                < 10000000000L and > -10000000000L => 10,
                < 100000000000L and > -100000000000L => 11,
                < 1000000000000L and > -1000000000000L => 12,
                < 10000000000000L and > -10000000000000L => 13,
                < 100000000000000L and > -100000000000000L => 14,
                < 1000000000000000L and > -1000000000000000L => 15,
                < 10000000000000000L and > -10000000000000000L => 16,
                < 100000000000000000L and > -100000000000000000L => 17,
                < 1000000000000000000L and > -1000000000000000000L => 18,
                _ => throw new ArgumentOutOfRangeException(nameof(n)),
            };
        }
    }
}
