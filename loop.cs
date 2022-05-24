namespace loop
{
    class looping
    {

        public void loopm()
        {
            int length = 5;
            System.Console.WriteLine("for loop");
            for (int i = 0; i < length; i++)
            {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine("While loop");
            while (length< 7)
            {
                System.Console.WriteLine(length);
                length++;
            }

            System.Console.WriteLine("Do While Loop");

            do
            {
                System.Console.WriteLine(length);
                length--;
            } while (length>2);

            int[] nums = {34,23,4,5,57,86,45,3};

            System.Console.WriteLine("Foreach Loop");
            foreach (var num in nums)
            {
                System.Console.WriteLine(num);
                
            }
        }
        
    }
    
    
}