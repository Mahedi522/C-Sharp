namespace Sort
{
    class QuicksortS
    {
        public void printArray(int[] arr)
        {
            foreach (var item in arr)
            {
                System.Console.Write(item + " ");
            }
        }
        public void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j]< pivot)
                {
                    i++;
                    swap( arr, i, j);
                }
            }
            swap(arr, i+1, high);
            return(i+1);

        }

        public void Quicksort(int[] arr, int low, int high)
        {

            if (low < high)
            {
                int pi = partition(arr, low, high);
                Quicksort(arr, low, pi-1);
                Quicksort(arr, pi+1, high);
            }
        }
        public void mainn()
        {
            int[] arr = {7, 5, 8, 3, 2};
            int l = arr.Length;
            Quicksort(arr, 0, l-1);
            printArray(arr);
        }
    }
}