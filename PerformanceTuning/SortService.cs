namespace PerformanceTuning
{
    public static class SortService
    {
        // BubbleSort: sorts the array in-place and returns the sorted array
        public static int[] BubbleSort(int[] data)
        {
            int[] arr = (int[])data.Clone();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
            return arr;
        }

        // QuickSort: sorts the array in-place and returns the sorted array
        public static int[] QuickSort(int[] data)
        {
            int[] arr = (int[])data.Clone();
            QuickSortInternal(arr, 0, arr.Length - 1);
            return arr;
        }

        private static void QuickSortInternal(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSortInternal(arr, low, pi - 1);
                QuickSortInternal(arr, pi + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }
    }
}
