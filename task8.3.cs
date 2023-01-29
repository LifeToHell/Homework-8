//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//6 16
//9 6
Console.Clear();
Console.Clear();
Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Наш первый массив");
int[,] second = new int[n, m];
int[,] first = new int[n, m];
RandomNumber(second);
RandomNumber(first);
void RandomNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100) / 10;
        }
    }
}
PrintRandomNumber(second);
Console.WriteLine("Наш второй  массив");
PrintRandomNumber(first);
void PrintRandomNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine("Произведение первой и второй матриц:");

int[,] C = Multiplication(second, first);
static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return r;
        }
PrintRandomNumber(C);


        


