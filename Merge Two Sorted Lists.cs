namespace margeList
{
    class TwoSortedLists
    {
        public int i = 0;
        public List<int> marged = new List<int>{};
        public void margeList()
        {
            int[] list1 = new int[]{1,3,5};
            System.Console.WriteLine("length of list1 : "+ list1.Length);
            int[] list2 = new int[]{1,2,3};
            System.Console.WriteLine("length of list2 : "+ list2.Length);
            fun1(list1, list2, ref marged);
            marged.Sort();
            foreach (var item in marged)
            {
                System.Console.WriteLine(item);                
            }
        }

        public void fun1(int[] x,int[] y, ref List<int> marged)
        {
            if (x.Length < i-1 && y.Length < i-1)
            {
                return;
            }
            // if (x.Length <= 0)
            // {
            //     fun2(x, y, ref marged);
            // }

            else
            {
                if (i< x.Length && x.Length != 0)
                {
                    marged.Add(x[i]);
                }
                fun2(x, y, ref marged);
            }
        }

        public void fun2(int[] x,int[] y, ref List<int> marged)
        {
            if (x.Length < i-1 && y.Length < i-1)
            {
                return;
            }
            
            // if (y.Length <= 0)
            // {
            //     fun1(x, y, ref marged);
            // }

            else
            {  
                if (i < y.Length&& x.Length != 0)
                {
                    marged.Add(y[i]);
                }
                i++;
                fun1(x, y, ref marged);
            }
            
        }
    }
}