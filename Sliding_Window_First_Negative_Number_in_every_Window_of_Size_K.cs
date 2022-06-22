namespace SlidingWindow
{
    class First_Negative_Number_in_every_Window_of_Size_K
    {
        public void First_Negative_Number_in_every_Window_of_Size_K_M(int[] arr, int k)
        {
            int i = 0,j = 0;
            List<int> li = new List<int>();
            Queue<int> q = new Queue<int>();
            while (j<arr.Length)
            {
                if (arr[j] < 0)
                {
                    q.Enqueue(arr[j]);
                } 
                if (j - i+1 < k)
                {
                    j++;
                }   
                else if(j - i+1 == k)
                {
                    if (q.Count == 0)
                    {
                        li.Add(0);
                    }
                    else 
                    {
                        li.Add(q.First());

                        if(arr[i] == q.First())
                        {
                            q.Dequeue();
                        }
                    }
                    i++;
                    j++;
                }       
            }
            System.Console.WriteLine("list");
            foreach (var item in li)
            {
                System.Console.Write(item+ " ");
            }
        }
        public void mainn()
        {
            int[] nums = {12, -1, -7, 8, -15, 30, 16, 28};
            int k = 3;
            First_Negative_Number_in_every_Window_of_Size_K_M(nums, k);
        }
    }
}