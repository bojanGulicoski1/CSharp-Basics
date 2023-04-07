using Class_Excersise.CLasses;
using Class_Excersise.Enums;

List<Person> listOfPersons = new List<Person>();

Person Bojan = new Person(3000 , 13 )
{
    FirstName = "Bojan",
    LastName = "Gulicoski",
    State = "Skopje",
    Email = "bojannn_gu@hotmail.com",
    Mobile = "075388967",
    hasDeposit = true,

};
Person riste = new Person(30000, 29)
{
    FirstName = "Riste",
    LastName = "Poposki",
    State = "Struga",
    Email = "r_p@hotmail.",
    Mobile = "098762",
    hasDeposit = true
};

Person aleksandra = new Person(33000, 29)
{
    FirstName = "Aleksandra",
    LastName = "Gulicoska :D",
    State = "Skopje",
    Email = "A_G@hotmail.com",
    Mobile = "22222",
    hasDeposit = false
};

bool hasValidEmail = aleksandra.EmailCheek();
var hasValidPhone = aleksandra.PhoneCheek();
bool isValidAge = aleksandra.CheekAge();
bool isValidCandidate = aleksandra.IsLoanCandidate();
if (hasValidEmail)
{
    Console.WriteLine("Valid Email");

}
else
{
    Console.WriteLine("Invalid email");
}
if (hasValidPhone)
{
    Console.WriteLine("Valid phone");
}
else
{

    Console.WriteLine("Phone number must starts with 07");
}
if (isValidAge)
{
    Console.WriteLine("Valid age for deposit");

}
else
{
    Console.WriteLine("Invalid age");
}
if (isValidCandidate)
{
    Console.WriteLine("deposit aproved");
}
else
{
    Console.WriteLine("Deposit denied");
}

