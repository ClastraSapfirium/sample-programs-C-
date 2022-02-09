// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int a = 0, b = 0;
string c;
Console.Clear();
System.Console.WriteLine("Введите значение Х ");
c = Console.ReadLine();
a = Convert.ToInt32(c);
System.Console.WriteLine("Введите значение Y ");
c = Console.ReadLine();
b = Convert.ToInt32(c);
if(a > 0 && b > 0) System.Console.WriteLine($"Точка с координатами Х = {a} Y = {b} находится в четверти №1 ");
if(a < 0 && b > 0) System.Console.WriteLine($"Точка с координатами Х = {a} Y = {b} находится в четверти №2 ");
if(a < 0 && b < 0) System.Console.WriteLine($"Точка с координатами Х = {a} Y = {b} находится в четверти №3 ");
if(a > 0 && b < 0) System.Console.WriteLine($"Точка с координатами Х = {a} Y = {b} находится в четверти №4 ");
if(a == 0 && b != 0) System.Console.WriteLine($"Точка пренадлежит оси Х");
if(a != 0 && b == 0) System.Console.WriteLine($"Точка пренадлежит оси Y");
if(a == 0 && b == 0) System.Console.WriteLine($"Точка имеет нулевые значения X и Y");
