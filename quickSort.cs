namespace Sort
{
    class QuickSort
    {
        public void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j <=  high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i+1, high);
            return(i+1);
        } 
        public void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi+1, high);

            }
        }
        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                System.Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
        }

        
        public void mainm()
        {
            int[] arr = {2,5,3,7,0,5,10};
            int n = arr.Length;
            quickSort(arr, 0, n-1);
            System.Console.Write("Sorted Array: ");
            printArray(arr,n);
        }
        
    }
}