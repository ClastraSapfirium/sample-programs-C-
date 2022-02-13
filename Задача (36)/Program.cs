// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int [] Arrey = new int [12];
int a = 0, b = 0;
Console.Clear();
for(int i=0; i< Arrey.Length; i++)
{
    Arrey[i] = new Random().Next(100, 1000);
    System.Console.Write($"{Arrey[i]} ");
    if (Arrey[i] % 2 == 0 ) a = a + 1;
    if (Arrey[i] % 2 != 0 ) b = b + 1;
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных элементов массива: {a}");
System.Console.WriteLine($"Количество нечетных элементов массива: {b}");