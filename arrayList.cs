namespace arrayList
{
    class arrayLi
    {
        

        public void arrayLiM()
        {
            int[] nums = new int[] {345,3,3,4,5};
            
            for(int i =0 ; i < nums.Length; i++)
                {
                    System.Console.WriteLine(nums[i]);
                }

            List<string> names = new List<string>();
            names.Add("Md");
            names.Add("Mahedi");
            names.Add("Al");
            names.Add("Arafat");
            System.Console.WriteLine("length of list is:"+names.Count);
            foreach(var name in names)
            {
                System.Console.WriteLine(name);

            }
            names.Remove("Md");
            names.RemoveAt(2);
            for(int i =0 ; i < names.Count; i++)
                {
                    System.Console.WriteLine(names[i]);
                }

        }
        
    }
    
}