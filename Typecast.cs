namespace TypeCast
{
    class TC
    {
        public void typeCastM()
        {
            double num1 = 566.34565;

            int num2 = Convert.ToInt32(num1);

            bool b = true;
            string bl = Convert.ToString(b);

            System.Console.WriteLine(num1.GetType());
            System.Console.WriteLine(num2.GetType());
            System.Console.WriteLine("{0}"+bl.GetType(),bl[1]);

        }
        
    }
    
}