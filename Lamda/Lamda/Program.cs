using Lamda;

Console.WriteLine("Welcome to Lamda Expression Problem");
List<CreatePerson> listPersonInCity = new List<CreatePerson>();
listPersonInCity.Add(new CreatePerson("456-37-8664", "Vandana", "Sai pragna residency 4 street", 16));
listPersonInCity.Add(new CreatePerson("488-94-9884", "geetha", "Akgila residency 7 street", 15));
listPersonInCity.Add(new CreatePerson("933-64-9684", "sneha", "Priya residency 7 street", 18));
listPersonInCity.Add(new CreatePerson("928-65-4647", "navya", "Geetha residency 7 street", 89));
listPersonInCity.Add(new CreatePerson("953-74-5474", "gopal", "TTD residency 7 street", 14));
listPersonInCity.Add(new CreatePerson("235-36-3774", "varshu", "Cv residency 7 street", 65));
listPersonInCity.Add(new CreatePerson("464-74-7677", "sriya", "Aditya residency 7 street", 38));

//UC-2
Console.WriteLine("\n______________________________________");
Console.WriteLine("Retrieving Top Two Aged persons From List Who Are Older Than 60 Years: ");
foreach (CreatePerson person in listPersonInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
{
    Console.WriteLine("Name: {0} \n Age: {1}", person.Name, person.Age);
}

//UC-3
Console.WriteLine("\n______________________________________");
Console.WriteLine("Checking Whether any person is teen ager or not: ");
foreach (CreatePerson person in listPersonInCity.FindAll(e => (e.Age >= 13 && e.Age <= 18)))
{
    Console.WriteLine("Name: {0} \n Age: {1}", person.Name, person.Age);
}

//UC4
Console.WriteLine("\n______________________________________");
Console.WriteLine("Getting Average Of All The Person's Age: ");
double averageAge = listPersonInCity.Average(e => e.Age);
{
    Console.WriteLine("The Average Of All The Person's Age Is: {0}", averageAge);
}

//UC5
Console.WriteLine("\n______________________________________");
Console.WriteLine("checking personn name present in the list");
foreach (CreatePerson person in listPersonInCity.FindAll(e => e.Name == "sriya"))
{
    Console.WriteLine("Yes,Name exist in your list");
}
//Uc-6
Console.WriteLine("\n______________________________________");
Console.WriteLine("\nSkkiping every persons whose aged is less than 60 years");
foreach (CreatePerson person in listPersonInCity.FindAll(e => e.Age < 60))
{
    //Console.WriteLine("Name:" + person.Name + "\t\tAge:" + person.Age);
    Console.WriteLine("Name: {0} \n Age: {1}", person.Name, person.Age);
}
