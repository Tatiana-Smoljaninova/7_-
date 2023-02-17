// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, что такого 
//элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.Write("Введите число поиска: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

int[,] array = new int[5,4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,10);
        Console.Write($"{array[i,j]} ");
        if (array[i,j] == num)
        {
            count++;
        }
    }
    Console.WriteLine();
}

if (count == 0)
{
     Console.WriteLine("Такого числа в массиве нет");
}
else 
{
    Console.WriteLine($"Значение {num} найдено");
}