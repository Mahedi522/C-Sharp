namespace linkedList
{
    class Llistprogram
    {
        class linkdlistNode
        {
            public int data;
            public linkdlistNode ?next;

            public linkdlistNode(int x)
            {
                data = x;
                next = null;
            }        
        }

    class linkdlistI
    {
        int count;
        linkdlistNode ?head;

        public linkdlistI()
        {
            head = null;
            count = 0;
        }

        public void addNodesFront(int data)
        {
            linkdlistNode node = new linkdlistNode(data);
            node.next = head;
            head = node;
            count++;
        }

        public void printList()
        {
            linkdlistNode ?runner = head;
            while (runner != null)
            {
                System.Console.WriteLine(runner.data);
                runner = runner.next;
            }
        } 
    }

    public void create()
    {
    linkdlistI linkedlist = new linkdlistI();
    linkedlist.addNodesFront(5);
    linkedlist.addNodesFront(15);
    linkedlist.addNodesFront(25);
    linkedlist.addNodesFront(35);
    linkedlist.addNodesFront(45);
    linkedlist.addNodesFront(55);

    linkedlist.printList();
    System.Console.WriteLine();
    }

    }
    
}