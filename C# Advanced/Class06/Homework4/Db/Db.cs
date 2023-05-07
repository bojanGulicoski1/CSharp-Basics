namespace Homework4.Db
{


    public static class Db
    {
        public static List<Person> People;
        public static List<Dog> Puppy;

        static Db()
        {

            People = new List<Person>() {

                new Person("Freddy", 23),
                new Person("Bojan", 29),
                new Person("Teodora", 22),
                new Person("Aleksandar", 44),
                new Person("Ronaldo", 50),
                new Person("Ramadan", 52),
                new Person("Nathen", 30),
                new Person("Nathen", 30)
            };


            Puppy = new List<Dog>() {
                new Dog("Dzeki", 3, "Brown"),
                new Dog("Kaya", 4, "Brown"),
                new Dog("Cristofer", 5, "Brown"),
                new Dog("Ajax", 6, "White"),
                new Dog("Roki", 1, "Black"),
                new Dog("Freddy", 3, "White"),
                new Dog("Rex", 2, "Brown"),
                new Dog("Amelia", 4, "Gold"),
                new Dog("Erin ", 1, "White"),
                new Dog("Elvin ", 2, "Brown"),
                new Dog("Erin ", 1, "White"),
                new Dog("Lui ", 2, "White"),
                new Dog("Lajka ", 4, "Brown"),
                new Dog("Rocky ", 6, "White"),
                new Dog("MAx ", 7, "Brown"),
        };

            People[0].AddDog(Puppy[0]);
            People[0].AddDog(Puppy[1]);
            People[1].AddDog(Puppy[2]);
            People[0].AddDog(Puppy[3]);
            People[4].AddDog(Puppy[4]);
            People[5].AddDog(Puppy[5]);
            People[6].AddDog(Puppy[6]);
            People[6].AddDog(Puppy[7]);
            People[7].AddDog(Puppy[8]);
            People[3].AddDog(Puppy[9]);
            People[2].AddDog(Puppy[10]);
            People[0].AddDog(Puppy[11]);
            People[4].AddDog(Puppy[12]);
            People[4].AddDog(Puppy[13]);
            People[3].AddDog(Puppy[14]);
            
        }


        public static void PrintInfo<T>(this List<T> list) where T : Person
        {
            Console.WriteLine($"Printing {list.Count} names");
            foreach (T name in list)
            {
                name.PrintInfo();
            }
        }
    }
}
