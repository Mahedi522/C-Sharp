namespace split
{
    class splitC
    {
        public void splitM()
        {
            string words = "1,2,3, word s sjnf ksde 12. vjnsd a";

            System.Console.WriteLine(words.Split(','));

            foreach (var item in words.Split(','))
            {
                System.Console.WriteLine(item);
                
            }

            char[] delimiters = new char[] {' ',',','.'};
            foreach (var item in words.Split(delimiters, StringSplitOptions.RemoveEmptyEntries))
            {
                System.Console.WriteLine(item);
            }
        }
    }
}