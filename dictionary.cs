namespace Dictionary
{
    class Dict
    {
        public void dictM(){
            Dictionary<int, int> ds = new Dictionary<int, int>();
            ds.Add(3,5);
            ds.Add(4,5);
            ds.Add(2,5);
            ds.Add(1,5);

            if (!ds.ContainsKey(5))
            {
                System.Console.WriteLine("NOT FOUND");
            }
            // foreach (KeyValuePair<int, int> item in ds)
            // {
            //     System.Console.WriteLine("key = {0}, Value is: {1}",item.Key,item.Value);
            // }
            
        }
        
    }
    
}