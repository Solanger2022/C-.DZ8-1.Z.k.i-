/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */   



        
int[,] arrayFirst = new int[2, 2];
int[,] arraySecond = new int [2, 2];
int[,] arrayThird =new int [2, 2];
Random random = new Random();


 for (int i = 0; i < arrayFirst.GetLength(0); i++)
{
 for (int j = 0; j < arrayFirst.GetLength(1); j++)
     {
        arrayFirst[i, j] = new Random().Next(11);
        Console.Write("{0} ", arrayFirst[i, j]);
     }
        Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < arraySecond.GetLength(0); i++)
{
 for (int j = 0; j < arraySecond.GetLength(1); j++)
       {
          arraySecond[i, j] = new Random().Next(11);
         Console.Write("{0} ", arraySecond[i, j]);
       }
Console.WriteLine();
 }
     Console.WriteLine();

for (int i = 0; i < arraySecond.GetLength(0); i++)
 {
  for (int k = 0; k < arrayThird.GetLength(1); k++)
 {
  for (int j = 0; j < arrayFirst.GetLength(1); j++)
         {
           arrayThird[i, j] = arrayFirst[i, k] * arraySecond[k, j];  
         }
 Console.Write("{0} ", arrayThird[i, k]);
}
    Console.WriteLine();
}

