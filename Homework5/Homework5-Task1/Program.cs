Console.WriteLine("Please enter a number !");
string userInput = Console.ReadLine();
bool isNumber = double.TryParse(userInput, out double numberInput);


if (isNumber)
{
    NumberStats(numberInput);
}
else
{
    Console.WriteLine("Invalid number");
}
void NumberStats(double numberInput)
{
    bool isPositive = true;
    bool isEven = true;
    bool isInteger = true;

    //Cheeking if number is positie or negative
    if (numberInput >= 0)
    {
        isPositive = true;
    }
    else
    {
        isPositive = false;
    }

    //Cheeking if number is odd or even

    if (numberInput % 2 == 0)
    {
        isEven = true;
    }
    else
    {
        isEven = false;
    }

    //Cheeking if number is integer or decimal

    if (numberInput % 1 == 0)
    {
        isInteger = true;
    }
    else
    {
        isInteger = false;
    }
      
    
    
    if (isPositive)
        {
            Console.WriteLine("Your number is: Positive! ");
        }
        else
        {
            Console.WriteLine("Your number is: Negative! ");
        }
        if (isEven)
        {
            Console.WriteLine("Your number is even!");
        }
        else
        {
            Console.WriteLine("Your number is odd!");
        }
        if (isInteger)
        {
        Console.WriteLine("Your number is integer!");
        }
        else
        {
        Console.WriteLine("Your number is decimal!");
      }
};


