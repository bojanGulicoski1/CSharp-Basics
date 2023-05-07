using Homework4;
using Homework4.Db;

List<Person> nameStartsWithR = Db.People.Where(x => x.Name.StartsWith("R")).OrderByDescending(x => x.Age).ToList();

nameStartsWithR.PrintInfo();

Console.WriteLine("\n");

List<Dog> nameColorAge = Db.Puppy.Where(x => x.Color == "Brown" && x.Age > 3).OrderByDescending(x => x.Age).ToList();

nameColorAge.PrintInfo();

Console.WriteLine("\n");

List<Person> ownesMoreThanTwoDogs = Db.People.Where(x => x.Dogs.Count > 2).OrderByDescending(x => x.Name).ToList();

ownesMoreThanTwoDogs.PrintInfo();
Console.WriteLine("\n");

List<Person> FrediesDogs = Db.People.Where(x => x.Name == "Freddy").ToList();

FrediesDogs.PrintInfo();

List<Dog> namedDogs = Db.Puppy.Where(x => x.Name == "Cristofer" ).ToList();

namedDogs.PrintInfo();