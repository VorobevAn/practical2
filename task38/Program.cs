

// Задача 38: Задайте массив вещественных чисел. 
// //Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



Console.Write("Задайте длину массива: ");
int saiz = int.Parse(Console.ReadLine()!);

int[] arrey = RealArray(saiz);
int max = MaxNamber(arrey);
int min = MinNamber(arrey);
int values = DifferenceValues();
Console.WriteLine($"Разница элементов ->{values}");

int[] RealArray(int saiz)
{
    int[] array = new int[saiz];
    for (int i = 0; i < saiz; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}
int MaxNamber(int[] arrey)
{
    max = arrey[0];
    for (int i = 0; i < saiz; i++)
    {
        if (arrey[i] > max)
        {
            max = arrey[i];
        }
    }
    Console.WriteLine($"Максимальный элемент: {max}");
    return max;
}
int MinNamber(int[] arrey)
{
    int min = arrey[0];
    for (int i = 0; i < saiz; i++)
    {
        if (arrey[i] < min)
        {
            min = arrey[i];
        }
    }
    Console.WriteLine($"Минимальный элемент: {min}");
    return min;
}
int DifferenceValues()
{
    values = max - min;
    return values;
}
