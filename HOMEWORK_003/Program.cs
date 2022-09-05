// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно
// на экран выводя индексы соответствующего элемента

void FillArray(int[,,] arr)
{
Random random = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
 {
   for (int j = 0; j < arr.GetLength(1); j++)
   {
      for (int k = 0; k < arr.GetLength(2); k++)
      {   
           while(arr[i,j,k] == 0)
              {
            int temp = random.Next(1,100);
            if(CheckNumbers(arr, temp) == false) arr[i,j,k] = temp;
              }
      }      
   }                 
 }      
}
bool CheckNumbers(int[,,] arr, int number)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
         for (int k = 0; k < arr.GetLength(2); k++)
         {
             if(arr[i,j,k] == number) return true;
         } 
      }       
   } 
   return false;
}
void PrintArray(int[,,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
         for (int k = 0; k < arr.GetLength(2); k++)
         {
            
            Console.Write(arr[i,j,k]);
            Console.Write("({0},{1},{2})  ",i,j,k);
         } 
         Console.WriteLine();
      } 
      Console.WriteLine();
   }        
} 
Console.WriteLine("Введите количество элементов массива по стороне 1: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество элементов массива по стороне 2: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество элементов массива по стороне 3: ");
int l = int.Parse(Console.ReadLine() ?? "0");
int[,,] array = new int[m,n,l];
FillArray(array);
PrintArray(array);
