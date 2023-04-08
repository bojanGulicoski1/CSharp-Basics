using homework1.Entities.Interfaces;

namespace homework1.Entities
{
    public class Dog : Animal , IDog
    {
        public Dog(string name, string color, int age) : base(name, color, age)
        {

        }

        public string Bark()
        {

            return $"{Name} is so loud when she do: AV AV AV ";
        }
        public override string PrintAnimal()
        {

            return $"{Name} with {Color} color is {Age} years old";
        }

    }
}
