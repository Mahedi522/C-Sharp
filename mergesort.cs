// namespace Sort
// {
//     class mergesort
//     {
//         public int mid;
//         public void merge(int[] arr, int left, int mid, int right)
//         {
//             int i;
//             int index_a, index_l, index_r;
//             int size_left, size_right;

//             size_left = mid - left +1;
//             size_right = right - mid;

//             int[] L = new int[size_left];
//             int[] R = new int[size_right];
            
//             for (i = 0; i < size_left; i++)
//             {
//                 L[i] = arr[left + i];
//             }

//             for (i = mid+1; i < size_right; i++)
//             {
//                 R[i] = arr[mid + i];
//             }

//             foreach (var item in L)
//             {
//                 System.Console.WriteLine("Left Item: "+item + " ");
//             }
//             foreach (var item in R)
//             {
//                 System.Console.WriteLine("Right Item: "+item + " ");
//             }
//         } 
//         public void mergesortM(int[] arr, int low, int high)
//         {
//             if (low<high)
//             {
//                 mid = low + (high-low)/2;
//                 mergesortM(arr, low, mid);
//                 mergesortM(arr, mid+1, high);
                
//                 System.Console.WriteLine("low: "+low+" mid: " +mid +" high: " +high);
//                 merge(arr, low, mid, high);
//             }   
//         }
//         public void mainn()
//         {
//             int[] arr = {5,2,9,3};
//             int l = arr.Length;
//             mergesortM(arr, 0, l-1);
//         }
//     }
// }
