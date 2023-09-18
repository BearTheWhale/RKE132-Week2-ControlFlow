Console.WriteLine("Hello, kasutaja!");

//Rakenus küsib kasutaja valida tema sugu (m/f)
//Rakendus küsib kasutaja vanust
//Kasutaja valikutele rakendus tervitav järgmiselt:
//"Welcome, Mr.(Kasutaja perenimi) /Welcome, Ms.(Kasutaja perenimi)

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //Loeb konsoolist maha andemid string (Sõne) dormaadis

Console.WriteLine("Please, enter your last name:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}