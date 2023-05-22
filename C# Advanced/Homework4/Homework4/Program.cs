using Homework4;
using Homework4.Db;

List<Person> nameStartsWithR = Db.People.Where(x => x.Name.StartsWith("R")).OrderByDescending(x => x.Age).ToList();
Console.WriteLine("Printing people starting with R:");
nameStartsWithR.PrintInfo();

Console.WriteLine("\n");

Console.WriteLine("Printing dogs with color brown and age  > 3:");
List<Dog> nameColorAge = Db.Puppy.Where(x => x.Color == "Brown" && x.Age > 3).OrderByDescending(x => x.Age).ToList();
nameColorAge.PrintInfo();

Console.WriteLine("\n");

Console.WriteLine("Printing people owning more than 2 dogs:");
List<Person> ownesMoreThanTwoDogs = Db.People.Where(x => x.Dogs.Count > 2).OrderByDescending(x => x.Name).ToList();
ownesMoreThanTwoDogs.PrintInfo();

Console.WriteLine("\n");

Console.WriteLine("Printig Freddies dogs older than 1 year:");
Person Freddy = Db.People.First(x => x.Name == "Freddy");
foreach (Dog dog in Freddy.Dogs)
{
    if (dog.Age > 1)
    {
        Console.WriteLine(dog.Name + " " + dog.Age + " " + "Years");
    }
}

Console.WriteLine("\n");

Console.WriteLine("Printing Nathaniel First dog");
Person Nathen = Db.People.First(x => x.Name == "Nathen");
Nathen.Dogs.First().PrintInfo();

Console.WriteLine("\n");

Console.WriteLine("Printing white dogs:");
List<string> whiteDogNames = Db.People
           .Where(x => x.Name == "Cristofer" || x.Name == "Freddy" || x.Name == "Erin" || x.Name == "Amelia")
           .SelectMany(x => x.Dogs)
           .Where(x => x.Color == "White")
           .OrderBy(x => x.Name)
           .Select(x => x.Name).ToList();

foreach (string dogName in whiteDogNames)
{
    Console.WriteLine(dogName);
}

Console.ReadLine();
