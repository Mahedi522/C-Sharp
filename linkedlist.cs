namespace linkedList
{
    public class linkedlist
    {
// AddAfter() - Adds a new element after the given element.
// AddBefore() - Adds a new element before the given element.
// AddFirst() - Adds a new element at the beginning of the list.
// AddLast() - Adds a new element at the end of the list.
// First - A property which returns the first element.
// Last- The property which returns the last element.
// RemoveFirst() - Removes the first element.
// RemoveLast() - Removes the last element.
        public void llist()
        {
            LinkedList<string> countryNames = new LinkedList<string>();
            LinkedListNode<string> head = countryNames.AddFirst("Bangladesh");
            countryNames.AddAfter(head,"India");
            countryNames.AddLast("USA");
            countryNames.AddLast("Pakistan");
            countryNames.AddLast("Nepal");

            // System.Console.WriteLine(countryNames.First.Value);
            foreach (var item in countryNames)
            {
                System.Console.WriteLine(item);
            }
            
            LinkedList<int> llist = new LinkedList<int>();
            LinkedListNode<int> ihead = llist.AddFirst(5);
            llist.AddAfter(ihead,10);
            LinkedListNode<int> middle = llist.AddLast(20);
            llist.AddLast(15);
            llist.AddLast(0);

            llist.AddBefore(middle,30);

            llist.RemoveLast();

            foreach (var item in llist)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}