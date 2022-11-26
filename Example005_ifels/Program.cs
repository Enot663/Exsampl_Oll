Console.Clear();
Console.WriteLine("Введите Ваше имя:  ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!!!!!!!");
}
else
{
    Console.WriteLine("Привет " + username + "!");
}