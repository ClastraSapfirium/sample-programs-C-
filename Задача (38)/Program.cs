// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int [] a = new int [20];
int sum = 0;
Console.Clear();
for(int i = 0;i < a.Length; i++)
    a[i]=new Random().Next(0,100);

for(int i = 0;i<a.Length;i++)   
    System.Console.Write($"{a[i]} ");

for (int i = 0; i < a.Length; i++)
{
    if(i%2 != 0) sum = sum + a[i];
}
System.Console.WriteLine($"Сумма чисел одномерного массива, стоящих на нечетных позициях, равна {sum}");
