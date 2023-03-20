int sumNumbers(int num1 , int num2)
{
    return num1 + num2;
}
int substractNumbers (int num1, int num2)
{
    return num1 - num2;
}
int divideNumbers (int num1, int num2)
{
    return num1 / num2;
}
int multiplyNumbers (int num1, int num2)
{
    return num1 * num2;
}

Console.WriteLine("PLease enter operator + , - , * , or /");
char operation = Convert.ToChar(Console.ReadLine());

Console.WriteLine ("Please enter first number");
int userInput1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Please enter second number");
int userInput2 = Convert.ToInt32(Console.ReadLine());


int finalResult(int num1, int num2)
{
    int result= 0;
    switch (operation)
    {
        case '+':
            result = sumNumbers(userInput1, userInput2);
            break;
        case '-':
            result =substractNumbers(userInput1, userInput2);
            break;
        case '*':
            result = multiplyNumbers(userInput1, userInput2);
            break;
        case '/':
            result = divideNumbers(userInput1, userInput2);
            break;

        default:
            Console.WriteLine("Sorry wrong operator ");
            break;

    }
    return result;
}
int res = finalResult(userInput1 , userInput2);
Console.WriteLine("Your result is" + " " + res);
