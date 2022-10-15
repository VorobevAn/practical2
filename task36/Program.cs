

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
Console.Write("Задайте длину массива: ");
int saiz = int.Parse(Console.ReadLine()!);
int[] arrey = new int[saiz];

NewArrew(arrey);
SumNambers(arrey);

int[] NewArrew(int[] mas)
{
    for (int i = 0; i < saiz; i++)
    {
        mas[i] = new Random().Next(-100, 100);
        Console.Write($"{mas[i]} ");
    }
    return mas;
}


int[] SumNambers(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < saiz; i++)
    {
        if (i % 2 != 0)
        {
            sum += arrey[i];
        }
    }
    Console.WriteLine($"сумма нечётных элементов:{sum}");

    return mas;
}