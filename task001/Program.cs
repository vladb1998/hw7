double[,] arr = new double [3 , 4];
for (int i = 0; i < arr.GetLength(0); i++)
{
   for (int j = 0; j < arr.GetLength(1); j++)
   {
    arr [i,j] = new Random().NextDouble();
    System.Console.Write($"{Math.Round (arr[i,j] , 2)} ; ");
   }
   System.Console.WriteLine();
} 