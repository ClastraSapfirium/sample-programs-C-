// Определить сколько чисел больше 0 введено с клавиатуры
double a = 0;
string s;
Console.Clear();
System.Console.WriteLine("Введите числовые значения в массив (следует учитывать что числа могут являтся как целыми так и вещественными).");
System.Console.WriteLine("Для завершения ввода числел введите 0.");
s = Console.ReadLine();
a = Convert.ToDouble(s);
List<double> QWE = new List<double> {};
while (a != 0)
{
    QWE.Add(a);
    System.Console.WriteLine("Ведите следующее числовое значение: ");
    s = Console.ReadLine();
    a = Convert.ToDouble(s);
}
double [] ASD = QWE.ToArray<double>();
Console.Clear();
System.Console.WriteLine("Введенный вами массив имеет следующий вид: ");
for (int i = 0; i < ASD.Length; i++)
{
    System.Console.Write($"{ASD[i]} ");
} 
int sum = 0;
for (int i = 0; i < ASD.Length; i++)
{
    if(ASD[i] > 0) sum++;
}
System.Console.WriteLine();
if (sum>0) System.Console.WriteLine($"Количество чисел которые больше 0 составляет {sum}");
if (sum==0) System.Console.WriteLine("Чисел больше 0 не обнаружено");