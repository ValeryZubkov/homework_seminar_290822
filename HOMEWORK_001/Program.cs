// Найти произведение двух матриц
void FillMatrix(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matr)
{
   for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    } 
}
int[,] DivMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matr = new int[matr1.GetLength(0), matr2.GetLength(1)];
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = 0;
                for (int n = 0; n < matr1.GetLength(1); n++)
                {
                    matr[i, j] = matr[i, j] + matr1[i, n] * matr2[n, j];
                }
            }
        }
    return matr;
}
Console.WriteLine("Введите количество строк 1-й матрицы: ");
int arow = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов 1-й матрицы: ");
int acol = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество строк 2-й матрицы: ");
int brow = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов 2-й матрицы: ");
int bcol = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix1 = new int[arow,acol];
int[,] matrix2 = new int[brow,bcol];
FillMatrix(matrix1);
FillMatrix(matrix2);
Console.WriteLine("Ваша матрица №1: ");
PrintMatrix(matrix1);
Console.WriteLine("Ваша матрица №2: ");
PrintMatrix(matrix2);
if(acol == brow)
{
Console.WriteLine("Произведение матрицы № 1 на матрицу № 2: ");
PrintMatrix(DivMatrix(matrix1, matrix2));
}
else
{
Console.WriteLine("К сожалению, данные матрицы нельзя умножать, т.к. не выполняется основное условие: количество столюцов матрицы №1 не равно количеству строк матрицы №2.");
}
