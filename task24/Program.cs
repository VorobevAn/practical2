

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задайте длину массива: ");
int saiz = int.Parse(Console.ReadLine()!);


int[] array = RandomArrey(saiz);
EvenNumbers(array);

int[] RandomArrey(int saiz)
{
    int[] array = new int[saiz];
    for (int i = 0; i < saiz; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int EvenNumbers(int[] mas)
{
    int caunt = 0;

    foreach (int el in mas)
    {
        if (el % 2 == 0)
        {
            caunt += 1;
        }
    }
    Console.WriteLine($"Количество чётных чисел:{caunt}");

    return caunt;
}