namespace strng
{
    public class strngc
    {

        public static string[] names = new string[10];
        List<string> list = new List<string>();
        public string firstName;
        public string lastName;
        public int age;
        public strngc(string firstName,string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }
        // string fullName = string.Concat(this.firstName,this.lastName);

        // System.Console.WriteLine(fullName);

        // System.Console.WriteLine(fullName.IndexOf("i"));

        public string fullName(){
            return string.Concat(firstName,lastName);
        }
    }
}





