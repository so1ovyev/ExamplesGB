// Двумерные массивы
//Массив строкю 2 - строки/ 3 - столбцы
// string [,] table = new string [2,3]
// Таблица чисел. 5 - строки / 8 - столбцы
// int [,] matrix = new int [5,8] 

// table [0,0]  table [0,1]  table [0,2]  table [0,3]  table [0,4]
// table [1,0]  table [1,0]  table [1,0]  table [1,0]  table [1,0]
//void PrintArrayString (string[,])
//{
//	string tab[1, 2] = "слово";
//	for (int i = 0; tab.GetLength(0); i++)
//	{
//		for (int j = 0; tab.GetLength(1); j++)
//		{
//			Console.WriteLine($"-{tab [i, j]}-");
//		}
//	}
//} // Не работает!



void PrintArray (int[,] mtrx)
{
	for (int i = 0; i < mtrx.GetLength(0); i++)
	{
		for (int j = 0; j < mtrx.GetLength(1); j++)
		{
			Console.Write($"{mtrx[i, j]} ");
		}
		Console.WriteLine();
	}
}

void FillArray(int[,] mtrx)
{
	for (int i = 0; i < mtrx.GetLength(0); i++)
	{
		for (int j = 0; j < mtrx.GetLength(1); j++)
		{
			mtrx[i,j] = new Random().Next(1, 10); // [1, 10)
		}
	}
}


//string[,] table = new string[2, 5];
//int[,] matrix = new int[3, 4];

//PrintArrayString(table);
//PrintArray(matrix);
//FillArray(matrix);
//Console.WriteLine();
//PrintArray(matrix);


int[,] pic = new int[,]
{
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
			//Console.Write($"{image[i, j]} ");
			if (image[i, j] == 0) Console.Write($" ");
			else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
	if (pic[row, col]==0)
	{
		pic[row, col] = 1;
		FillImage (row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}

//Ф-ция вызывающая сама себя - рекурсия.

//PrintImage(pic);
//FillImage(13, 13);
//PrintImage(pic);

//int Factorial (int n) // при типе данных int - переполнение
//double Factorial(int n)
//{
//	if (n == 1) return 1;
//	else return n * Factorial (n-1);
//}
//for (int i = 1; i < 40; i++)
//{
	//Console.WriteLine(Factorial(i));
//	Console.WriteLine($"{i}! = {Factorial(i)}");
//}
//Console.WriteLine(Factorial(3));
//Console.WriteLine(Factorial(4));
//Console.WriteLine(Factorial(5));

//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f (n-2)

double Fibonacci (int n)
{
	if (n == 1 || n == 2) return 1;
	else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 40; i ++)
{
	Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

