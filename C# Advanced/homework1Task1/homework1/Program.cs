using homework1.Entities;


Dog dog = new Dog("Kaya" , "Brown" , 4);
Cat cat = new Cat("Tom", "Blue", 7 , true);

Console.WriteLine(dog.Bark());
Console.WriteLine(cat.Eat("Fishes"));
Console.WriteLine(dog.PrintAnimal());
Console.WriteLine(cat.PrintAnimal());   