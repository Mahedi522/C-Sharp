namespace conditional
{
    class conditionC
    {
        public int num;

        public conditionC(int num)
        {
            this.num = num;
        }

        public void condition()
        {
            if (this.num <= 17 && this.num >=1)
            {
                System.Console.WriteLine("kid");
            }
            else if (this.num >=18 )
            {
                System.Console.WriteLine("Young");
            }
            else if (this.num >= 50)
            {
                System.Console.WriteLine("Old");
            }
            else
            {
                System.Console.WriteLine("invalid");
            }


            var output = (this.num % 2 ==  0) ? "Even" : "Odd";
            System.Console.WriteLine("output is : "+ output );


            


            
        }
        
        
    }
}