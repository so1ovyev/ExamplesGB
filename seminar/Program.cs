Console.WriteLine ("Введите число А");

int numberA = int.Parse(Console.ReadLine());

double result = Math.Pow(numberA, 2);
string s = $"квадрат от числа {numberA} равен {result}";

System.Console.WriteLine(s);
