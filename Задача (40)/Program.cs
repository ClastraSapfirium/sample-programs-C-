// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double a = 0;
string s;
Console.Clear();
System.Console.WriteLine("Ведите числовые значения в массив (следует учитывать что числа могут являтся как целыми так и вещественными).");
System.Console.WriteLine("Для завершения ввода числел введите 0.");
s = Console.ReadLine();
a = Convert.ToDouble(s);
List<double> QWE = new List<double> {}; //Составляем список введённых чисел!
while (a != 0)
{
    QWE.Add(a);
    System.Console.WriteLine("Ведите следующее числовое значение: ");
    s = Console.ReadLine();
    a = Convert.ToDouble(s);
}
double [] ASD = QWE.ToArray<double>(); //Конвертируем составленый выше список и переносим его в массив 
System.Console.WriteLine("Введенный вами массив имеет следующий вид: ");
for (int i = 0; i < ASD.Length; i++)
{
    System.Console.Write($"{ASD[i]} ");
} 

double max = ASD[0];
double min = ASD[0];
for (int i = 0; i < ASD.Length; i++)
{
    if(ASD[i] > max) max = ASD[i];
    if(ASD[i] < min) min = ASD[i];
}
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементами составляет: {max - min}");