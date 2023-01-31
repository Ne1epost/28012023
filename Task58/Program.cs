// задача 58
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random(). Next(-10, 10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] firstMatr, int[,] secondMatr, int[,] resultMatr)
{
  for (int i = 0; i < resultMatr.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatr.GetLength(1); k++)
      {
        sum += firstMatr[i,k] * secondMatr[k,j];
      }
      resultMatr[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


Console.WriteLine($"Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMatr = new int[m, n];

CreateArray(firstMatr);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMatr);

int[,] secondMatr = new int[n, p];
CreateArray(secondMatr);
Console.WriteLine($"Вторая матрица:");
WriteArray(secondMatr);

int[,] resultMatr = new int[m,p];

MultiplyMatrix(firstMatr, secondMatr, resultMatr);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatr);

