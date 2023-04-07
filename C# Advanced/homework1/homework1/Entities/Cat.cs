using homework1.Entities.Interfaces;

namespace homework1.Entities
{
    public class Cat : Animal, ICat
    {
        public bool Purr { get; set; }
        public Cat(string name, string color, int age, bool purr) : base(name, color, age)
        {
            Purr = purr;
        }

        public string Eat(string food)
        {
            return $"{Name} wants to eat a lot of {food}";
        }

        public override string PrintAnimal()
        {
            if (Purr)
            {
                return $"{Name} with {Color} color is {Age} years old and have ability to Purr";
            }
            return $"{Name} with {Color} color is {Age} years old";
        }
    }
}
