//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.


int ReadInt(string coordinates)
{
    Console.Write($"Input {coordinates}: ");
    return int.Parse(Console.ReadLine());
}

int xA = ReadInt("Enter xA: ");
int yA = ReadInt("Enter yA: ");
int zA = ReadInt("Enter zA: ");
int xB = ReadInt("Enter xB: ");
int yB = ReadInt("Enter yB: ");
int zB = ReadInt("Enter zB: ");

#region
//Console.WriteLine("Enter the x coordinates for the point A: ");
//int xA = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the y coordinates for the point A: ");
//int yA = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the z coordinates for the point A: ");
//int zA = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the x coordinates for the point B: ");
//int xB = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the y coordinates for the point B: ");
//int yB = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the z coordinates for the point B: ");
//int zB = int.Parse(Console.ReadLine());
#endregion

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
Console.WriteLine(Math.Round(distance, 2));



