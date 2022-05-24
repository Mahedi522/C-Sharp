namespace Enosis
{
    class ReverseC
    {
        public void ReverseM()
        {
            string str = "We are students.";
            
            // char[] charArray = str.ToCharArray();
            // Array.Reverse( charArray );
            // System.Console.WriteLine(charArray);
            // string x = new string(charArray);
            // // String charArray_ = Convert.ToString(charArray);
            // System.Console.WriteLine(x.GetType());
            

            char[] delimiters = new char[] {' ',',','.'};
            
            foreach (var item in str.Split(delimiters))
            {
                char[] chararray = item.ToCharArray();
                Array.Reverse(chararray);
                string rvs = new string(chararray);
                System.Console.WriteLine(rvs);
                
            }
        }
        
    }
    
}