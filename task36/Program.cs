

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
Console.Write("Задайте длину массива: ");
int saiz = int.Parse(Console.ReadLine()!);


int[] array = NewArrey(saiz);
int amount = AmountNambers();
Console.WriteLine($"сумма нечётных элементов:{amount}");

int[] NewArrey(int saiz)
{
    int[] array = new int[saiz];
    for (int i = 0; i < saiz; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write($"{array[i]} ");
    }
    return array;
}
int AmountNambers()
{
    int amount = 0;
    for (int i = 0; i < saiz; i++)
    {
        if (i % 2 != 0)
        {
            amount += array[i];
        }
    }
    return amount;
}