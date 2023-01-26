string name = "Jowita";
string gender = "Female";
int age = 28;


if (name == "Jowita" && gender == "Female" && age == 28)
{
    Console.WriteLine("Wszystko się zgadza");
}

else
{
    Console.WriteLine("Lipa");
}

if (gender == "Female" && age < 30)
{
    Console.WriteLine("Kobieta przed 30");
}
else if (gender == "Female" && age > 30)
{
    Console.WriteLine("Kobieta po 30");
}