//Метод 1 не возвращают,, не принимают
using Microsoft.VisualBasic;

void Method1()
{
    Console.WriteLine("Автор....");
}
//Method1();
//Console.WriteLine();

//Метод 2. Принимает, не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}
//Method2_1("Привет", 2);
//При вызове методов без именованных аргументов обязательно писать по порядку
//Method2_1(count: 5, msg: "Hello");
//При использовании именованных аргументов писать по порядку не обязательно

//Метод 3. Возвращает, не принимает
int Method3()
{
    return DateTime.Now.Year;

}
int year = Method3();
Console.WriteLine(year);
Console.WriteLine();

//Метод 4. Возвращает, Принимает.
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count) 
    {    
        result += text;
        i ++;
    }
    return result;
}
string res = Method4(3, "Hello ");
//Console.WriteLine(res);

string Method4_1(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}
string reslt = Method4(4, "Hello, ");
//Console.WriteLine(reslt);

//Таблица умножения:
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine ($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
