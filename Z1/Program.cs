// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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
int[,] matrix = GenerateMatrix(2, 3, 1, 10);

int rowsIndex = ReadInt("Задайте номер строки искомого элемента: ");

int colsIndex = ReadInt("Задайте номер столбца искомого элемента: ");

//проверка входит ли число в границы массива

if (rowsIndex < 3 && colsIndex < 4)
{
    Console.WriteLine("Вы это число загадали? ");
    Console.WriteLine(matrix[rowsIndex - 1, colsIndex - 1]);
}
else
     Console.WriteLine("Массив не содержит такой элемент");


Console.WriteLine("Вот такой у нас массив: \t ");
PrintMatrix(matrix);

