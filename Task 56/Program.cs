// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Количество строк: ");
int lines=Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns=Convert.ToInt32(Console.ReadLine());
int[,]numbers=new int[lines,columns];
int[]linsumArray=new int[lines];
FillArray(numbers);
PrintArray(numbers);
for(int i=0;i<numbers.GetLength(0);i++)
{
    int sum=0;
    for (int j=0; j<numbers.GetLength(1);j++)
    sum=sum+numbers[i,j];
    linsumArray[i]=sum;
    Console.WriteLine($"Сумма строки {i}:{linsumArray[i]}");
}
Console.WriteLine();
int minsum=linsumArray[0];
int linminsumnumber=0;
for (int i=0; i<linsumArray.Length; i++)
{
    if(minsum>linsumArray[i])
    {
        minsum=linsumArray[i];
        linminsumnumber=1;
    }
}
Console.WriteLine($"Строка номер {linminsumnumber} с наименьшей суммой элементов {minsum}");
void FillArray (int[,]array)
{
    Random rand=new Random();
    for (int i=0;i<array.GetLength(0);i++)
    for (int j=0; j<array.GetLength(1); j++)
    array[i,j]=rand.Next(0,100);
}
void PrintArray(int[,]array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        Console.Write(array[i,j]+ "; ");
        Console.WriteLine();
    }
}
