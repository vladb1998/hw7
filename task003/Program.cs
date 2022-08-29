int m = new Random().Next(1,10);
int n = new Random().Next(1,10);
int[,] array = new int [m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
    array[i,j] = new Random().Next(1,10);
    System.Console.Write($"{array[i,j]} ");
   }
   System.Console.WriteLine();
} 
System.Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i,j];
    }
    System.Console.Write($"{Math.Round(sum / m , 2)} ; ");
}
