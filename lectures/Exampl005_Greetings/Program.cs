Console.Write("Введите имя пользователя: ");
string  username = Console.ReadLine();

if (username.ToLower() == "artem")
{
    Console.WriteLine("Salam, Artem!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}