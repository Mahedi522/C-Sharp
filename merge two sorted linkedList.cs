namespace LeetCode
{
    class mergelinkedList
    {
        public int i = 0;
        public void mergeLlist()
        {
            LinkedList<int> llist1 = new LinkedList<int>();
            LinkedList<int> llist2 = new LinkedList<int>();

            LinkedListNode<int> head = llist1.AddFirst(1);
            llist1.AddAfter(head, 2);
            llist1.AddLast(4);
            print(llist1);

            LinkedListNode<int> head1 = llist2.AddFirst(1);
            llist2.AddAfter(head1, 3);
            llist2.AddLast(4);
            print(llist2);
            
            
        }

        public void print(LinkedList<int> llist1)
        {
            LinkedListNode<int> runner = llist1.First;
            while (runner != null)
            {
                System.Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
        }
        // public void fun1(int[] x,int[] y, ref List<int> marged)
        // {
        //     if (x.Length < i-1 && y.Length < i-1)
        //     {
        //         return;
        //     }
        //     else
        //     {
        //         if (i< x.Length && x.Length != 0)
        //         {
        //             marged.Add(x[i]);
        //         }
        //         fun2(x, y, ref marged);
        //     }
        // }

        // public void fun2(int[] x,int[] y, ref List<int> marged)
        // {
        //     if (x.Length < i-1 && y.Length < i-1)
        //     {
        //         return;
        //     }
        //     else
        //     {  
        //         if (i < y.Length&& x.Length != 0)
        //         {
        //             marged.Add(y[i]);
        //         }
        //         i++;
        //         fun1(x, y, ref marged);
        //     }
            
        // }
    }
}