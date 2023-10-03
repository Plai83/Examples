Console.WriteLine("Введите Ваше имя");
string? userName = Console.ReadLine();
if (userName.ToLower() == "Маша") 
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(userName);
}