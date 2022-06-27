Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "лиля" )
{
    Console.WriteLine("Ура, это же ЛИЛЯ!");
}
   else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
