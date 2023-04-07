//Swap Numbers  - Task One

int number1, number2;
Console.Write("Input the First Number : ");
number1 = int.Parse(Console.ReadLine());
Console.Write("Input the Second Number : ");
number2 = int.Parse(Console.ReadLine());
(number1, number2) = (number2, number1);
Console.Write("After Swapping : ");
Console.Write("\nFirst Number : " + number1);
Console.Write("\nSecond Number : " + number2);

//SumOfEven - Task Two

int[] array = new int[6];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Enter integer {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int sumOfEven = 0;
foreach (int num in array)
{
    if (num % 2 == 0)
    {
        sumOfEven += num;
    }
}
Console.WriteLine($"The sum of even numbers is {sumOfEven}");


//Student group 

string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = { "Igor", "Bojan", "Darko", "Zivko", "Ivan" };

Console.WriteLine("Enter Student group:(There are 1 and 2)");

int userChoice = Convert.ToInt32(Console.ReadLine());

if (userChoice == 1)
{
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (userChoice == 2)
{
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }

}
else
{
    Console.WriteLine("PLease enter 1 or 2");
}

