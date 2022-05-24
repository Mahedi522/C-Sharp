namespace Enosis
{
    class IpValidationC
    {
        public void IpValidationM()
        {
            string ip = "255.255.255.0.255";
            int count = 0;
            foreach (var item in ip.Split("."))
            {
               
                // System.Console.WriteLine("Type of x is: "+x.GetType());
                // System.Console.WriteLine(item);

                try
                {
                    int x = Convert.ToInt32(item);
                    if (x >= 0 && x <= 255)
                    {
                        count += 1;
                    } 
                    else
                    {
                        System.Console.WriteLine("The value of fields of the IP address is not valid.");
                        break;
                    }
                }
                catch (FormatException)
                {                    
                    System.Console.WriteLine("Invalid format for IP address");
                }
                    
            }

            if (count == 4)
            {
                System.Console.WriteLine("The IP address is valid.");
            }
            else
            {
                System.Console.WriteLine("The IP address is not valid.");
            }
        }
    }
}