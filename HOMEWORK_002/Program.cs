// В двумерном массиве целых чисел. 
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void FillMatrix(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
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
Console.WriteLine("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m,n];
FillMatrix(matrix);
Console.WriteLine("Ваш массив: ");
PrintMatrix(matrix);
int min = matrix[0,0];
int minI = 0;
int minJ = 0;
for(int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
     if(matrix[i,j] < min) 
     {
        min = matrix[i,j];
        minI = i;
        minJ = j;
     }
    }
 }
Console.WriteLine($"Наименьший элемент {min} находится на пересечнии {minI+1}-й строки и {minJ+1}-го столбца."); 
int[,] matrixNew = new int[m-1,n-1];
for(int i=0; i<m-1; i++)
{
  for(int j=0; j<n-1; j++)
  {     
    if(i<minI && j<minJ) matrixNew[i,j] = matrix[i,j];
    if(i>=minI && j<=minJ) matrixNew[i,j] = matrix[i+1,j];
    if(i<=minI && j>=minJ) matrixNew[i,j] = matrix[i,j+1];
    if(i>=minI && j>=minJ) matrixNew[i,j] = matrix[i+1,j+1];
  }
}
Console.WriteLine("Модифицированный массив: ");
PrintMatrix(matrixNew);


