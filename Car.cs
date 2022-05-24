namespace Car
{
    class car_
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public car_(int hp, string color)
        {
             this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            System.Console.WriteLine("HP: "+ HP + " Color: " + Color);
        }
        public virtual void Repair()
        {
            System.Console.WriteLine("The car was repaired");
        }

    }
    
}