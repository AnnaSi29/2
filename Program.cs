// Задание 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Задание 1. Введите количество строк  ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


// Задание 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Задание 2. Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Изначальный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(10, 99);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
    if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
Console.WriteLine("Элемента нет");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadLine();

// Задание 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

System.Console.WriteLine("Введите кол-во строк"); 
int linesVol = Convert.ToInt32(Console.ReadLine());  
System.Console.WriteLine("Введите кол-во столбцов"); 
int columnsVol = Convert.ToInt32(Console.ReadLine());  
System.Console.WriteLine();
int [ , ] array = new int [linesVol, columnsVol];     
FillArrayRandomArray(array);   
PrintArray(array); 
for(int j =0; j<array.GetLength(1); j++) 

{
    int mean = 0;
    for(int i =0; i<array.GetLength(0); i++) 
    {
        mean = (mean + array[i,j]);
    }
    mean = mean/columnsVol;
    System.Console.Write(mean + ";");
}

System.Console.WriteLine();
void FillArrayRandomArray(int[ , ] array)
{
    for(int i =0; i<array.GetLength(0); i++)                
    {
        for(int j =0; j<array.GetLength(1); j++)            
        {
            array[i,j] = new Random().Next(0,10);   
        }
    }
}

void PrintArray(int[ , ] array){                                      
    for(int i=0; i<array.GetLength(0); i++)                                
    {
        for(int j=0; j<array.GetLength(1); j++)                            
        {
            System.Console.Write(array [i,j]+"\t");                       
        }
        System.Console.WriteLine();
    }
}
