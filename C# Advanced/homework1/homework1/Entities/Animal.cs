using homework1.Entities.Interfaces;

namespace homework1.Entities
{
    public abstract class Animal : IAnimal
    {

        public string Name { get; set; }    

        public string Color { get; set; }

        public int Age { get; set; }

        public Animal(string name , string color , int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }
        public abstract string PrintAnimal();
        
    }
}
