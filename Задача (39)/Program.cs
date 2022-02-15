// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int a = 0;
string s;
Console.Clear();
System.Console.WriteLine("Введите размер массива: ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

int [] arr = new int [a];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next (0,10);
}

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();
System.Console.Write($"произведение пар чисел в одномерном массиве: ");
for (int i = 0; i < arr.Length/2; i++)
{
    System.Console.Write($"{arr[i]*arr[a-1-i]} ");
}