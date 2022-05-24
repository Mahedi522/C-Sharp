
namespace list

{
    class listC
    {
        public void listM()
        {
            List<int> myNumbers = new List<int> {2,4,5,7,8,45, 3,1,3,6,3};
            
            myNumbers.Add(45);
            myNumbers.Remove(45);
            // myNumbers.RemoveRange(0,2);
            
            //at specific position
            myNumbers.Insert(0,50);
            myNumbers.Sort();
            myNumbers.Reverse();
            
            foreach (var num in myNumbers)
            {
                System.Console.WriteLine(num);
            }
            System.Console.WriteLine("Current size of list is: "+ myNumbers.Count);
            System.Console.WriteLine("index of 3 is: {0}",myNumbers.IndexOf(3));

            //normal method
            // List<int> numberOver5 = new List<int>();
            // foreach (var num in myNumbers)
            // {
            //     if (num>5) numberOver5.Add(num);
            // }

            // System.Console.WriteLine(numberOver5);

            //Lambda

            var numberOver5 = myNumbers.Where(number => number>5);
            foreach (var num in numberOver5)
            {
                System.Console.WriteLine(num);
            }

        }
    }
    
}