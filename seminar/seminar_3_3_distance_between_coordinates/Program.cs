//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ниму в 2D пространстве 


Console.WriteLine("Enter the x coordinates for the point A: ");
int xA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the y coordinates for the point A: ");
int yA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the x coordinates for the point B: ");
int xB = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the y coordinates for the point B: ");
int yB = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
//Math.Pow(xA - xB, 2) - Возведение в степень (в данном случае 2)
Console.WriteLine(Math.Round(distance, 3));
//Math.Round(distance, 3) - уменьшает количество знаков после запятой (в данном случае до 3х)
