// Напишите программу, которая на вход принимает число (N)
// и выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("Enter the number: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{    
    Console.WriteLine ($"Square number {i} = {Math.Pow(i, 2)}");
}
