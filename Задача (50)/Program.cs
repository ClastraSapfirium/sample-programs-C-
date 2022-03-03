// В двумерном массиве n×k заменить четные элементы на противоположные
int a,b;
string c,d;
Console.WriteLine("Введите количество строк массива: ");
c = Console.ReadLine();
a= Convert.ToInt32(c);
Console.WriteLine("Введите количество столбцов массива: ");
d = Console.ReadLine();
b= Convert.ToInt32(d);

int [,] particle = new int [a,b];
for (int i=0; i<particle.GetLength(0); i++)
{
    for (int e=0; e<particle.GetLength(1); e++)
    {
        particle [i,e]= new Random ().Next(1,100);
    }
}

for (int i=0; i<particle.GetLength(0); i++)
{
    for (int e=0; e<particle.GetLength(1); e++)
    {
        if (particle [i,e]%2==0) particle[i,e]= -particle[i,e];
        System.Console.Write(particle[i,e]+" ");
    }
    System.Console.WriteLine();
}
