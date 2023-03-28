using Homework5_Task2.Classes;

User user1 = new User();
user1.UserName = "Bojan";
user1.Password = "123456";
user1.Messages.Add("message1");
user1.Messages.Add("message4");


User dejan = new User();
dejan.UserName = "Dejan";
dejan.Password = "testpassword";
dejan.Messages.Add("message2");
dejan.Messages.Add("message7");


User trajan = new User();
trajan.UserName = "Trajan";
trajan.Password = "1562";
trajan.Messages.Add("message3");
trajan.Messages.Add("message5");
trajan.Messages.Add("message6");


List<User> listUsers = new List<User>();
listUsers.Add(user1);
listUsers.Add(dejan);
listUsers.Add(trajan);


while (true)
{
    Console.WriteLine("Press 1 to Log In ");
    Console.WriteLine("Press 2 to Sign Up ");
    string userChoose = Console.ReadLine();

    if (userChoose == "1")
    {
        Console.Write("Please Enter your username: ");
        string userName = Console.ReadLine();
        Console.Write("PLease enter your password: ");
        string password = Console.ReadLine();


        User existingUser = FindUserByUsernameAndPassword(listUsers, userName, password);

        if (existingUser != null)
        {
            Console.WriteLine($"Welcome {existingUser.UserName} Here are your messages");
          
            foreach (string message in existingUser.Messages)
            {
                Console.WriteLine($"{message}");
            }
        }
        else
        {
            Console.WriteLine("No User found !");
        }

    }
    else if (userChoose == "2")
    {
        Console.WriteLine("Please enter new id");
        string id = Console.ReadLine();

        Console.WriteLine("Please enter new username");
        string username = Console.ReadLine();

        Console.WriteLine("Please enter new password");
        string password = Console.ReadLine();

        User existingUser = null;
        foreach (User user in listUsers)
        {
            if (user.UserName == username)
            {
                existingUser = user;
            }
        }

        if (existingUser != null)
        {
            Console.WriteLine("That user already exists");
        }
        else
        {
            User newUser = new User();
            newUser.UserName = username;
            newUser.Password = password;
            listUsers.Add(newUser);

            foreach (User user in listUsers)
            {
                Console.WriteLine($"{user.Id} {user.UserName}");
            }
        }
    }

    Console.WriteLine("\n");
}



User FindUserByUsernameAndPassword(List<User> users, string userName, string password)
{
    foreach (User user in users)
    {
        if (user.UserName == userName && user.Password == password)
        {
            return user;
        }
    }

    return null;
};

