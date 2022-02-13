// Определить, присутствует ли в заданном массиве, некоторое число
int n = 0;
bool f = false;
string s;
int [] a = new int [10];
Console.Clear();
for(int i = 0;i < a.Length; i++)
{
    a[i]=new Random().Next(0,100);
}
for(int i = 0;i<a.Length;i++)
{
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
System.Console.WriteLine("Введите число для поиска в массиве");
s = Console.ReadLine();
n = Convert.ToInt32(s);

for (int i = 0; i < a.Length; i++)
{
    if(a[i] == n)
    {
        f = true;
        break;
    }
}
if(f) System.Console.WriteLine($"Число {n} присутствует в массиве");
else System.Console.WriteLine($"Число {n} в массиве не обнаружено");