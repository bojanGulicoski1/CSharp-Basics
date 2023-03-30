using Class_Excersise.CLasses;
using Class_Excersise.Enums;

List<Person> listOfPersons = new List<Person>();

Person Bojan = new Person()
{
    FirstName = "Bojan",
    LastName = "Gulicoski",
    Age = 29,
    State = "Skopje",
    Email = "bojannn_gu@hotmail.com",
    Mobile = "075388967",
    enumBankProducts = EnumBankProducts.Deposit,
    MontlyVague = 50000

};
Bojan.LoanCandidates(Bojan.Age, Bojan.MontlyVague, Bojan.hasDeposit);
Bojan.EmailCheek(Bojan.Email);
Bojan.PhoneCheek(Bojan.Mobile);
Bojan.CheekAge(Bojan.Age);
