Console.WriteLine ("Введите число А: ");                        
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

double result = Math.Pow(numberB, 2);
string s = ""; 

if (numberA == result)
{
    //s = "да";
    s = $"да, квадрат от числа {numberB} равен {numberA}";
}
else 
{
    //s = "нет";
    s = $"нет, квадрат от числа {numberB} не равен {numberA}";
}
System.Console.WriteLine(s);
