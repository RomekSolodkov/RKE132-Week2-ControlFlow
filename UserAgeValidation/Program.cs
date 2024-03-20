Console.WriteLine("Please, select youre gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please, enter youre last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f') 
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
