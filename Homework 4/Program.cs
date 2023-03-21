////Take one string from the input and print its last 5 characters.
//Console.WriteLine("Please insert sentence not shorter than 6 characters");
//string userInput = Console.ReadLine();
//Console.WriteLine("Please ente a number");
//int numInput = Convert.ToInt32(Console.ReadLine());
//string last5 = userInput.Substring(userInput.Length - numInput);
//Console.WriteLine($" Last {numInput} characthers of your sentence are - {last5}");


////Take a sentence as input and print its words.
//Console.WriteLine("Enter a sentence");
//string userSentence = Console.ReadLine();
//string[] splitedSentence = userSentence.Split(" ");

//foreach (string s in splitedSentence)
//{
//    Console.WriteLine(s);
//};





////Create a function that takes a number as input. This method should return the sum of the digits in the number.
//Console.WriteLine("Please enter a number!");
//int numberInput = Convert.ToInt32(Console.ReadLine());
//string getSum(int numberInput)
//{
//    int sum = 0;
//    while (numberInput != 0)
//    {
//        sum = sum + numberInput % 10;
//        numberInput = numberInput / 10;
//    }
//    return $"The sum of the digits in your number is  {sum}";
//}

//Console.WriteLine(getSum(numberInput));


//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date

Console.WriteLine("Please enter your year of birth ");
string inputUser = Console.ReadLine();

string AgeCalculator(string inputUSer)
{
    DateTime dateOfBirth = Convert.ToDateTime(inputUSer);
    int age = DateTime.Now.Year - dateOfBirth.Year;
    return $"You are {age} years old!";
}
Console.WriteLine(AgeCalculator(inputUser));

   