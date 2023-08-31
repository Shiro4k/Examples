System.Console.Write("Привет Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "коля")
{
    System.Console.WriteLine("Ура это же КОЛЯ");
}
else
{
    System.Console.WriteLine("Привет, ");
    System.Console.WriteLine(username);
}