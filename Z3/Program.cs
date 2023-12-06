// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int rows = ReadInt("Введите количество строк в матрице: ");

int cols = ReadInt("Введите количество столбцов в матрице: ");

int[,] matrix = GenerateMatrix(rows, cols, 1, 10);

PrintMatrix(matrix);

int SumLine(int[,] matrix, int i)
{
int sum = matrix[i,0];
for (int j = 1; j < matrix.GetLength(1); j++)
{
sum += matrix[i,j];
}
return sum;
}

int minSum = 1;
int sum = SumLine(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
if (sum > SumLine(matrix, i))
{
sum = SumLine(matrix, i);
minSum = i+1;
}
}
Console.WriteLine("Строка c наименьшей суммой элементов: №" + (minSum));


