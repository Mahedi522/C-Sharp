namespace  inheritancen
{
    class Animal
    {
        public string? name;
        public int age;
        public string? color;
        public string? sound;
        

        

        // public Animal(string _name, int _age, string _color, string _sound)
        // {
        //     name = _name;
        //     age = _age;
        //     sound = _sound;
        //     sound = _sound;

        // }
        
        public void printDetails(){
            System.Console.WriteLine("name: "+ name + " Age: "+ age + " Color: "+ color);
        }
    }
    class Dog : Animal
    {
        public string bred;

        public void Bred(){
            System.Console.WriteLine("Bred is: "+ bred);
        }
        public void  Sound()
        {
            System.Console.WriteLine(name+" sounds like: "+ sound);
        }
        public Dog(string _name, int _age, string _color, string _bred, string _sound)
        {
            name = _name;
            age = _age;
            bred = _bred;
            sound = _sound;
            color = _color;
        }
    }
    // class Cat
    // {
    //     public 
        
    // }
    
}