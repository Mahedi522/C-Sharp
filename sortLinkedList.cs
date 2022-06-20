namespace linkedList
{
    class sortLinkedList
    {
        class linklistNode
        {
            public int val;
            public linklistNode ?next;
            public linklistNode(int x)
            {
                val = x;
                next = null;
            } 
        }

        class LList
        {
            int count;
            linklistNode ?head;
            public LList()
            {
                head = null;
                count = 0;
            }
            public void addnodefront(int data)
            {
                linklistNode node = new linklistNode(data);
                node.next = head;
                head = node;
                count ++;
            }
            public void print()
            {
                linklistNode ?runner = head;
                while (runner != null)
                {
                    System.Console.WriteLine(runner.val);
                    runner = runner.next;
                }
            }
        }

        public void create()
        {
            LList linklist = new LList();
            linklist.addnodefront(5);
            linklist.addnodefront(15); 
            linklist.addnodefront(5);
            linklist.print();
        }
    }
    
}