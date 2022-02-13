// Написать программу замены элементов массива на противоположные
int [] Arrey = new int [12];
Console.Clear();
for(int i=0; i< Arrey.Length; i++)
{
    Arrey[i] = new Random().Next(-9, 10);
    System.Console.Write($"{Arrey[i]} ");
    Arrey[i] = Arrey[i]*(-1);
}
System.Console.WriteLine();
for (int i = 0; i < Arrey.Length; i++)
{
    System.Console.Write($"{Arrey[i]} ");
}