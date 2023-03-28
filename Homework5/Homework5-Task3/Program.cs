using Homework5_Task3.Classes;

Customer customer1 = new Customer()
{
    FullName = "Bojan Gulicoski",
    CardNumber = "1234-1234-1234-1234",
    Pin = "0000",
    Balance = 5000

};

Customer customer2 = new Customer()
{
    FullName = "Aleksandra Aleksoski",
    CardNumber = "2234-2234-2234-2234",
    Pin = "1111",
    Balance = 3000
};


Customer customer3 = new Customer()
{
    FullName = "Teodora Gulicoska",
    CardNumber = "2224-2224-2224-2224",
    Pin = "2222",
    Balance = 4000
};

List<Customer> BankUsers = new List<Customer>();
BankUsers.Add(customer1);
BankUsers.Add(customer2);
BankUsers.Add(customer3);

Console.WriteLine("Welcome to the ATM app");
Console.WriteLine("If you have account press Y");
Console.WriteLine("If you want to register press R");
string firstUserChoise = Console.ReadLine();

if (firstUserChoise.ToUpper() == "Y")
{
    Console.WriteLine("Please enter your Card number: ");
    string userCardNumber = Console.ReadLine();
    Console.WriteLine("Please enter your Pin code: ");
    string userPinCode = Console.ReadLine();
    Customer bankCustomers = FindBankUser(BankUsers, userCardNumber, userPinCode);
    if (bankCustomers != null)
    {
        Console.WriteLine($"Welcome {bankCustomers.FullName}");
        while (true)
        {
            Console.WriteLine("Please choose your action!");
            Console.WriteLine("1:Balance checking");
            Console.WriteLine("2:Cash withdrawal");
            Console.WriteLine("3:Cash deposition");
            Console.WriteLine("If you want to cancel pred X");
            string userChoise = Console.ReadLine();
            if (userChoise == "1")
            {
                Console.WriteLine($"Your balance is {bankCustomers.Balance}");
            }
            else if (userChoise == "2")
            {
                Console.WriteLine($"How much money you want to withdrawal?-Avalivable {bankCustomers.Balance}");
                int cashWithdrawaled = Convert.ToInt32(Console.ReadLine());
                if (cashWithdrawaled > bankCustomers.Balance)
                {
                    Console.WriteLine("Not enought money");
                }
                else
                {
                    bankCustomers.CashWithdrawl(cashWithdrawaled);
                    Console.WriteLine($"You have withdrawaled {cashWithdrawaled} and left {bankCustomers.Balance}");
                }
            }
            else if (userChoise == "3")
            {
                Console.WriteLine($"How much money you want to deposit");
                int cashDeposition = Convert.ToInt32(Console.ReadLine());
                bankCustomers.CashDeposition(cashDeposition);
                Console.WriteLine($"Transaction sucessfull , new balance: {bankCustomers.Balance}");
            }
            else if (userChoise.ToUpper() == "X")
            {
                Console.WriteLine($"Thank you for beliving in us {bankCustomers.FullName}");
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("Customer not found!");
    }
    Customer FindBankUser(List<Customer> users, string cardNumber, string pinCode)
    {
        foreach (Customer customer in users)
        {
            if (customer.CardNumber == userCardNumber && customer.Pin == userPinCode)
            {
                return customer;
            }
        }
        return null;
    }
}




else if (firstUserChoise.ToUpper() == "R")
{
    Console.WriteLine("Please enter your full name");
    string fullName = Console.ReadLine();
    Console.WriteLine("Please enter new card number");
    string newUSerCardNumber = Console.ReadLine();
    Console.WriteLine("Please enter your pin code");
    string newUserPinCode = Console.ReadLine();


    Customer newBanUser = FindBankUser(BankUsers, newUSerCardNumber, newUserPinCode);
    if (newBanUser != null)
    {
        Console.WriteLine("This card number is taken.");
    }
    else if (newBanUser == null)
    {
     
        Customer newCustomer = new Customer();
        newCustomer.FullName = fullName;
        newCustomer.CardNumber = newUSerCardNumber;
        newCustomer.Pin = newUserPinCode;
        Console.WriteLine("Your registration is successfull!");
        BankUsers.Add(newBanUser);


    }
    Customer FindBankUser(List<Customer> users, string cardNumber, string pinCode)
    {
        foreach (Customer customer in users)
        {
            if (customer.CardNumber == newUSerCardNumber && customer.Pin == newUserPinCode)
            {
                return customer;
            }
        }
        return null;
    }
};
