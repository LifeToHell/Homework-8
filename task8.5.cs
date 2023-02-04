//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:

Console.Clear();
Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Наш массив");
int[,] number = new int[n, m];

FillNumber(number);
void FillNumber(int[,] array)
{
    int temp = 1;
int i = 0;
int j = 0;

while (temp <= number.GetLength(0) * number.GetLength(1))
{
  number[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < number.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= number.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > number.GetLength(1) - 1)
    j--;
  else
    i--;
}
}
PrintRandomNumber(number);
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