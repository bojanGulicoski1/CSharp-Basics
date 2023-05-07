namespace Homework4
{
    public class Dog : Person
    {
        public string Color { get; set; }

        public Dog(string name, int age , string color ) : base(name, age)
        {
            Name = name;
            Age = age;
            Color = color;
          
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name}  {Age}  {Color}");
        }
    }
}
