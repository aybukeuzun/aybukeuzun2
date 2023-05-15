

Console.WriteLine("Enter your last name");
string lastname = Console.ReadLine();

Console.WriteLine("enter yoru gender (f/m/n):");
Char usergender = Char.Parse(Console.ReadLine());
string greeting;

if (usergender == 'f')
{
    greeting = "Ms.";
}
else if (usergender == 'm')
{
    greeting = "Mr.";
}

else
{
    greeting = "";
}
Console.WriteLine($"hello {greeting} {lastname}!");
Console.WriteLine("enter your year of birth:");

int userYB = int.Parse(Console.ReadLine());

int currentYear = DateTime.Now.Year;
int userAge = currentYear - userYB;

//Console.WriteLine($"Current year: {currentYear}");



//int userAge = Int32.Parse(Console.ReadLine());

if (userAge >= 13)
{
    Console.WriteLine($"you are {userAge} - old enough to have an account");
}
else
{
    Console.WriteLine($"you are {userAge} - too young to have an account");
}