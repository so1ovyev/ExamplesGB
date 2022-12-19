Console.WriteLine ("Введите число А: ");                        
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

double result = Math.Pow(numberB, 2);
string s = ""; 

if (numberA == result)
{
    s = "да";
}
else 
{
    s = "нет";
}
System.Console.WriteLine(s);
