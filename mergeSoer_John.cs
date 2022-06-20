// namespace Sort
// {
//     class mergeSort_John
//     {
//         public void mainn()
//         {
//             Random rand = new Random();
//             int[] numbers = new int[10];
//             for (int i = 0; i < numbers.Length; i++)
//             {
//                 numbers[i] = rand.Next(100);
//             }
//             System.Console.WriteLine("before: ");
//             // foreach (var item in numbers)
//             // {
//             //     System.Console.Write(item+" ");
//             // }
//             mergeSort(numbers);
//             System.Console.WriteLine("After: ");
//             foreach (var item in numbers)
//             {
//                 System.Console.Write(item+" ");
//             }
//         }
//         public static void mergeSort(int[] inputArray)
//         {
//             int inputLength = inputArray.Length;

//             if (inputLength < 2)
//             {
//                 return;
//             }
//             int midIndex = inputLength/2;
//             int[] lefthalf = new int[midIndex];
//             int[] righthalf = new int[inputLength - midIndex];

//             for (int i = 0; i < midIndex; i++)
//             {
//                 lefthalf[i] = inputArray[i];
//             }
//             for (int i = midIndex; i < inputLength; i++)
//             {
//                 righthalf[i-midIndex] = inputArray[i];
//             }

//             mergeSort(lefthalf);
//             mergeSort(righthalf);
//         }
//     }
// }