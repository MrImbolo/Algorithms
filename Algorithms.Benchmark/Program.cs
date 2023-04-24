using Algorithms.Sorting;

int[] sample = SortAlgorithmsHelper.GetSampleArrayCopy(100, 1, 100);

Console.WriteLine($"============================== Sorting algorithms ===============================");
Console.WriteLine($"Initial array: \n[{string.Join(',', sample)}]");

Console.WriteLine($"================================== Bubble Sort ==================================");
sample = SortAlgorithmsHelper.GetSampleArrayCopy(10, 1, 20);
SortAlgorithmsHelper.ResetArrayPrinter();
sample.BubbleSort(true);
SortAlgorithmsHelper.AssertSorted(sample, "[BubbleSort] Array is not sorted: ");
Console.WriteLine($"=================================    Done!    ===================================\n\n");


Console.WriteLine($"================================= Shaker Sort ===================================");
sample = SortAlgorithmsHelper.GetSampleArrayCopy(10, 1, 20);
SortAlgorithmsHelper.ResetArrayPrinter();
sample.ShakerSort(true);
SortAlgorithmsHelper.AssertSorted(sample, "[ShakerSort] Array is not sorted: ");
Console.WriteLine($"=================================    Done!    ===================================\n\n");


Console.WriteLine($"=================================  Comb Sort  ===================================");
sample = SortAlgorithmsHelper.GetSampleArrayCopy(10, 1, 20);
SortAlgorithmsHelper.ResetArrayPrinter();
sample.CombSort(true);
SortAlgorithmsHelper.AssertSorted(sample, "[CombSorter] Array is not sorted: ");
Console.WriteLine($"=================================    Done!    ===================================\n\n");


Console.WriteLine($"================================ InsertionSort ==================================");
sample = SortAlgorithmsHelper.GetSampleArrayCopy(10, 1, 20);
SortAlgorithmsHelper.ResetArrayPrinter();
sample.InsertionSort(true);
SortAlgorithmsHelper.AssertSorted(sample, "[InsertionSort] Array is not sorted: ");
Console.WriteLine($"=================================    Done!    ===================================\n\n");


Console.WriteLine($"================================= SelectionSort ===================================");
sample = SortAlgorithmsHelper.GetSampleArrayCopy(10, 1, 20);
SortAlgorithmsHelper.ResetArrayPrinter();
sample.SelectionSort(true);
SortAlgorithmsHelper.AssertSorted(sample, "[SelectionSort] Array is not sorted: ");
Console.WriteLine($"=================================    Done!    ===================================\n\n");

