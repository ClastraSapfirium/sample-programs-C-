// Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива
int [] Arrey = new int [12];
int a = 0, b = 0;
Console.Clear();
for(int i=0; i< Arrey.Length; i++)
{
    Arrey[i] = new Random().Next(-9, 10);
    System.Console.Write($"{Arrey[i]} ");
    if (Arrey[i] > 0 ) a = a + Arrey[i];
    if (Arrey[i] < 0 ) b = b + Arrey[i];
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных элементов массива {a}");
System.Console.WriteLine($"Сумма отрицательных элементов массива {b}");