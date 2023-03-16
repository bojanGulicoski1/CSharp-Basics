//// See https://aka.ms/new-console-template for more information

////Task One- Real Calculator
//Console.WriteLine("Enter First Number:");
//int input1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Second Number:");
//int input2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Operator:");
//string inputOperator = Console.ReadLine();
//if (inputOperator == "+")
//{
//    Console.WriteLine(input1 + input2);
//}
//if (inputOperator == "-")
//{
//    Console.WriteLine(input1 - input2);
//}
//if (inputOperator == "*")
//{
//    Console.WriteLine(input1 * input2);
//}
//if (inputOperator == "/")
//{
//    Console.WriteLine(input1 / input2);
//}

//Task Two - Average numbers

int input3 = Convert.ToInt32(Console.ReadLine());
int input4 = Convert.ToInt32(Console.ReadLine());
int input5 = Convert.ToInt32(Console.ReadLine());
int input6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((input3 + input4 + input5 + input6) / 4);

//Task one with switch
//Real calculator
Console.WriteLine("Please enter number one");
int userNum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number two");
int userNum2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter operator");
char operatorInput = Convert.ToChar(Console.ReadLine());

switch (operatorInput)
{
    case '+':
        Console.WriteLine(userNum1 + userNum2);
        break;

    case '-':
        Console.WriteLine(userNum1 - userNum2);
        break;
    case '*':
        Console.WriteLine(userNum1 * userNum2);
        break;
    case '/':
        Console.WriteLine(userNum1 / userNum2);
        break;
    default:
        Console.WriteLine("Wrong operator");
        break;
}
