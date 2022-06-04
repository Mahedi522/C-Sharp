namespace ds
{
    class arrayMultiJagged
    {
        public void ArrayTest()
        {
            int [] array = new int[] {1, 2, 3, 4};
            foreach (var item in array)
            {
                System.Console.WriteLine(item);

                
            }
            try
                {
                    array[5] = 10;
                }
                catch ( Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                     
                }


                int[,] a = {
                    {1, 2, 3},
                    {4, 5, 6}
                };
                System.Console.WriteLine(
                    $"A multi -dimentional array length: {a.Length}"
                );
                //first element in the first row, first column
                a[0, 0] = 10;

                int[][] b = {
                    new int[] {1, 2, 3},
                    new int[] {10, 20, 30, 40, 50},
                    new int[] {5, 6},
                    new int[] {7, 8, 9, 0}
                };
                System.Console.WriteLine($"The jagged array length: {b.Length}");
                System.Console.WriteLine($"The nested array length: {b[1].Length}");
                //The first elements first element
                b[0][0] = 10;

                int[][][] c = new int [2][][];
                //int[2][2][2] or int[2][2][] is not possible]
                //you can initialize only the first rank
                //also, nested arrays are not initialized,
                //c[0].Length will give null references exception
        }
        
    }
}