namespace Homework4
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;

        public int  Age { get; set; }


        public List<Dog> Dogs { get; set; }

        public Person(string name , int age )
        {
            Name = name;
            Age = age;
            Dogs = new List<Dog>();
        }
        public void AddDog(Dog dog)
        {
            Dogs.Add(dog);
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name}  {Age} ");
        }

        
    }
}
